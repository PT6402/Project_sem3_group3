using System;
using Api.Data_helper;
using Api.Interface.IRepo;
using Api.Interface.IService;
using AutoMapper;
using Lib.Dto;
using Lib.Dto.Coupon;
using Lib.Dto.EmployeeDto;
using Lib.Dto.FeedbackSend;
using Lib.Dto.Product.Ctrl;
using Lib.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Repository
{
    public class EmployeeRepository : IEmployee
    {
        private readonly DatabaseContext _db;
        private readonly IPassword _pass;
        private readonly IMapper _mapper;
        public EmployeeRepository(DatabaseContext db, IPassword pass, IMapper mapper)
        {
            _db = db;
            _pass = pass;
            _mapper = mapper;
        }


        public async Task<IEnumerable<EmployeeDto>> GetEmployees()
        {
            var list = await _db.Employees.ToListAsync();
            var res = new List<EmployeeDto>();
            foreach (var emptype in list)
            {
                var user = await _db.Users.FirstOrDefaultAsync(x => x.Id == emptype.User_Id);

                EmployeeDto newE = new EmployeeDto()
                {
                    Phone = user.Phone,
                    Email = user.Email,
                    FullName = user.FullName,
                    Id = emptype.Id,
                    Employee_type_id = emptype.Employee_type_Id,
                    Address_store_id = emptype.Address_store_Id
                };
                res.Add(newE);
            }
            return res;
        }

        public async Task<string> CreateEmp(EmployeeDto model)
        {
            try
            {
                var Emptype = _db.Employee_types.FirstOrDefault(x => x.Id == model.Employee_type_id);

                var check = _db.Users.FirstOrDefault(x => x.Phone == model.Phone);


                if (check != null)
                {
                    var checkemp = _db.Employees.FirstOrDefault(x => x.User_Id == check.Id);
                    if (checkemp != null)
                    { return "false"; }

                    check.Role = "Emp_" + Emptype!.Name;
                    await _db.SaveChangesAsync();

                    Employee newemp = new Employee()
                    {
                        User_Id = check.Id,
                        Employee_type_Id = model.Employee_type_id,
                        Address_store_Id = model.Address_store_id

                    };
                    await _db.AddAsync(newemp);
                    await _db.SaveChangesAsync();
                    return "true";
                }
                else
                {
                    var pass = _pass.CreatePassword("employeepass");
                    User newuser = new()
                    {
                        Phone = model.Phone,
                        Email = model.Email,
                        FullName = model.FullName,
                        Role = "Emp_" + Emptype!.Name,
                        PasswordHash = pass.PasswordHash,
                        PasswordSalt = pass.PasswordSalt
                    };
                    await _db.AddAsync(newuser);
                    await _db.SaveChangesAsync();
                    Employee newemp = new Employee()
                    {
                        User_Id = newuser.Id,
                        Employee_type_Id = model.Employee_type_id,
                        Address_store_Id = model.Address_store_id

                    };
                    await _db.AddAsync(newemp);
                    await _db.SaveChangesAsync();
                    return "true";
                }

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<DtoResult<EmployeeDto>> Delete(int id)
        {
            try
            {
                var coup = await _db.Employees.FirstOrDefaultAsync(x => x.Id == id);
                if (coup != null)
                {
                    _db.Employees.Remove(coup);
                    await _db.SaveChangesAsync();
                    return new()
                    {
                        Status = true,
                        Message = "Delete successfully"
                    };
                }
                else
                {
                    return new()
                    {
                        Status = false,
                        Message = "Delete fail!"
                    };
                }
            }
            catch (Exception ex)
            {
                return new()
                {
                    Status = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<DtoResult<EmployeeDto>> Edit(EmployeeDto model)
        {
            try
            {
                var emp = await _db.Employees.FirstOrDefaultAsync(
                    c => c.Id.Equals(model.Id));
                var Emptype = _db.Employee_types.FirstOrDefault(x => x.Id == model.Employee_type_id);
                var user = await _db.Users.FirstOrDefaultAsync(x => x.Id == emp.User_Id);
                if (emp != null)
                {

                    emp.Employee_type_Id = model.Employee_type_id;
                    emp.Address_store_Id = model.Address_store_id;
                    user.FullName = model.FullName ?? user.FullName;
                    user.Role = "Emp_" + Emptype!.Name;
                    user.Phone = model.Phone ?? user.Phone;
                    user.Email = model.Email ?? user.Email;
                    await _db.SaveChangesAsync();
                    return new()
                    {
                        Status = true,
                        Message = "Update successfully",
                        //Model = new EmployeeDto()
                        //{
                        //    Id = emp.Id
                        //}
                    };

                }

                return new()
                {
                    Status = false,
                    Message = "Update fail"
                };
            }
            catch (Exception ex)
            {
                return new()
                {
                    Status = false,
                    Message = ex.Message
                };
            }
        }

        //technician function
        public async Task<DtoResult<List<ProductDto>>> CheckProduct(checkProduct check)
        {
            try
            {
                var order = await _db.Order
                    .Include(d => d.Duration)
                    .ThenInclude(p => p.Package)
                    .ThenInclude(c => c.Connect_type)
                    .FirstOrDefaultAsync(x => x.Id == check.Order_Id);

                var storage = await _db.Storages.FirstOrDefaultAsync(o => o.Address_store_id == check.Address_Store_Id);

                if (storage == null)
                {
                    return new DtoResult<List<ProductDto>>
                    {
                        Status = false,
                        Message = "Storage not found."
                    };
                }

                var importedProducts = await _db.ImportReceipt
                    .Where(x => x.Storage_id == storage.Id)
                    .ToListAsync();

                List<ProductDto> productList = new List<ProductDto>();

                foreach (var import in importedProducts)
                {
                    var product = await _db.Products.FirstOrDefaultAsync(x =>
                        x.Id == import.Product_Id &&
                        x.Numb_Connect >= order.Numb_Connect &&
                        x.Connect_type_Id == order.Duration.Package.Connect_type_Id);

                    if (product != null)
                    {
                        ProductDto productDto = _mapper.Map<ProductDto>(product);

                        if (import.Quantity > 0)
                        {
                            productList.Add(productDto);
                        }
                    }
                }

                // Kiểm tra trường hợp quantity < 1
                if (productList.Count == 0)
                {
                    var productsWithLowQuantity = importedProducts
                        .Where(x => x.Quantity < 1)
                        .Select(x => x.Product_Id)
                        .ToList();
                    if (productsWithLowQuantity.Count == 0) {

                        var imre = await _db.ImportReceipt.Where(x => x.Storage_id == storage.Id).Select(o => o.Product_Id).ToListAsync();
                        var productsNotInImportReceipt = await _db.Products.Where(p => !imre.Contains(p.Id) &&
                          p.Numb_Connect > order.Numb_Connect &&
                             p.Connect_type_Id == order.Duration.Package.Connect_type_Id)
                         .ToListAsync();
                        var productsNotInImportReceiptDto = productsNotInImportReceipt
                        .Select(x => _mapper.Map<ProductDto>(x))
                        .ToList();
                        return new DtoResult<List<ProductDto>>
                        {
                            Status = false,
                            Model = productsNotInImportReceiptDto,
                            Message = "Our store not have but company have"

                        };
                    }
                    // Kiểm tra trường hợp 1: Có sản phẩm phù hợp nhưng quantity < 1
                    if (productsWithLowQuantity.Count > 0)
                    {
                        var productsWithLowQuantityDto = await _db.Products
                            .Where(x => productsWithLowQuantity.Contains(x.Id)
                             && x.Numb_Connect >= order.Numb_Connect
                             && x.Connect_type_Id == order.Duration.Package.Connect_type_Id)
                            .Select(x => _mapper.Map<ProductDto>(x))
                            .ToListAsync();
                        if (productsWithLowQuantityDto.Count==0)
                        {

                            var imre = await _db.ImportReceipt.Where(x => x.Storage_id == storage.Id).Select(o => o.Product_Id).ToListAsync();
                            var productsNotInImportReceipt = await _db.Products.Where(p => !imre.Contains(p.Id) &&
                              p.Numb_Connect > order.Numb_Connect &&
                                 p.Connect_type_Id == order.Duration.Package.Connect_type_Id)
                             .ToListAsync();

                            var productsNotInImportReceiptDto = productsNotInImportReceipt
                            .Select(x => _mapper.Map<ProductDto>(x))
                            .ToList();
                            if (productsNotInImportReceiptDto.Count == 0) {
                                return new DtoResult<List<ProductDto>>
                                {
                                    Status = false,
                                    Message = "No matching products found."
                                };
                            }
                            return new DtoResult<List<ProductDto>>
                            {
                                Status = false,
                                Model = productsNotInImportReceiptDto,
                                Message = "Our store not have but company have"

                            };

                        }
                        return new DtoResult<List<ProductDto>>
                        {
                            Status = false,
                            Message="low stock at store",
                            Model = productsWithLowQuantityDto
                        };
                    }



                    // Kiểm tra trường hợp 3: Không có sản phẩm phù hợp trong Products
                   
                }

                // Trường hợp có sản phẩm phù hợp (quantity > 1)
                return new DtoResult<List<ProductDto>>
                {
                    Status = true,
                    Model = productList
                };
            }
            catch (Exception ex)
            {
                return new DtoResult<List<ProductDto>>
                {
                    Status = false,
                    Message = ex.Message
                };
            }
        }

      

        public async Task<bool> StaffEditStatus(string Order_Id)
        {
            var orcheck = await _db.Order.FirstOrDefaultAsync(x => x.Id == Order_Id);
            if (orcheck != null)
            {
                orcheck.Status = "Confirmed";
                await _db.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> StaffStatusPayment(string Order_Id)
        {
            var orcheck = await _db.Order.FirstOrDefaultAsync(x => x.Id == Order_Id);
            if (orcheck != null)
            {
                orcheck.Status = "Payment";
                await _db.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> StaffStopOrder(string Order_Id)
        {
            var orcheck = await _db.Order.FirstOrDefaultAsync(x => x.Id == Order_Id);
            if (orcheck != null)
            {
                orcheck.Status = "Stop Order";
                await _db.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> TechEditStatus(string Order_Id)
        {
            var orcheck = await _db.Order.FirstOrDefaultAsync(x => x.Id == Order_Id);
            if (orcheck != null)
            {
                orcheck.Status = "Techn Confirmed";
                await _db.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<DtoResult<Feedback>> Sendfeed(SendDto send)
        {
            try
            {
                var order = await _db.Order.FirstOrDefaultAsync(x => x.User_Id == send.User_Id);
                var du = await _db.Feedbacks.FirstOrDefaultAsync(x => x.Duration_Id == send.Duration_Id);
                if (order != null && !ContainsProfanity(send.Content) && order.Status == "Finish")
                {
                    Feedback newFe = new Feedback()
                    {
                        User_Id = send.User_Id,
                        Duration_Id = send.Duration_Id,
                        Address_Store_Id = send.Address_Store_Id,
                        Content = send.Content
                    };
                    await _db.AddAsync(newFe);
                    await _db.SaveChangesAsync();
                    return new()
                    {
                        Status = true,
                        Message = "send successfully"
                    };
                }
                return new()
                {
                    Status = false,
                    Message = "send fail or you feedback on this package"
                };

            }
            catch (Exception ex)
            {
                return new()
                {
                    Status = false,
                    Message = ex.ToString()
                };
            }

        }

        [NonAction]
        private bool ContainsProfanity(string content)
        {
            // Kiểm tra xem content có chứa các từ khóa như "fu" hay "shit" không
            string[] profanityKeywords = { "fu", "shit" };
            foreach (var keyword in profanityKeywords)
            {
                if (content.ToLower().Contains(keyword.ToLower()))
                {
                    return true;
                }
            }
            return false;
        }

        public async Task<IEnumerable<Feedback>> SeeFeed()
        {
            return await _db.Feedbacks.ToListAsync();
        }

        public async Task<DtoResult<Feedback>> Replyfeed(ReplyDto reply)
        {
            try
            {

                var feedback = await _db.Feedbacks.FirstOrDefaultAsync(x => x.Id == reply.Feedback_Id);
                if (feedback != null && feedback.Reply == null)
                {
                    feedback.Reply = reply.Reply;
                    await _db.SaveChangesAsync();
                    return new()
                    {
                        Status = true,
                        Message = "reply successfully"
                    };
                }
                return new()
                {
                    Status = true,
                    Message = "reply fail "
                };
            }
            catch (Exception ex)
            {
                return new()
                {
                    Status = false,
                    Message = ex.Message
                };
            }
        }

        

    }
}



