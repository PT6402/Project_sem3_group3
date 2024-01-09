using Api.Data_helper;
using Api.Interface.IRepo;
using AutoMapper;
using Lib.Dto;
using Lib.Dto.OrderHandler;
using Lib.Dto.Orders;
using Lib.Entities;
using Microsoft.EntityFrameworkCore;
using Polly;
using static Azure.Core.HttpHeader;

namespace Api.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DatabaseContext _db;
        private readonly IMapper _mapper;
        public OrderRepository(DatabaseContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<DtoResult<OrderDto>> Create(OrderDto orderDto)
        {
            try
            {
                Addresses newAddress = new()
                {
                    Address_full = orderDto.Address_full,
                    Province_code = orderDto.Province_code,
                    Phone_code = orderDto.Phone_code,
                    District_code = orderDto.District_code,
                    Ward_code = orderDto.Ward_code
                };
                _db.Address.Add(newAddress);
                await _db.SaveChangesAsync();
                var TaxDefautl = 0.1224;

                int durationId = orderDto.Duration_Id;
                var connectTypeFirstLetter = _db.Durations
                .Where(d => d.Id == durationId)
                .Select(d => d.Package!.Connect_type!.First_Letter)
                .FirstOrDefault();


                var User = _db.Users.Where(u => u.Id.Equals(orderDto.User_Id)).FirstOrDefault();
                string phoneUser = User!.Phone;

                if (connectTypeFirstLetter != null)
                {
                    orderDto.Id = connectTypeFirstLetter + phoneUser;

                    Order order = new Order()
                    {
                        Id = orderDto.Id,
                        Status = "Processing",
                        Tax = TaxDefautl.ToString(),
                        Total_Price = orderDto.Total_Price,
                        Numb_Connect = orderDto.Numb_Connect,
                        Duration_Id = orderDto.Duration_Id,
                        Coupon_Id = orderDto.Coupon_Id,
                        ContractService_Id = orderDto.ContractService_Id,
                        User_Id = orderDto.User_Id,
                        Addresses_Id = newAddress.Id
                    };
                    _db.Order.Add(order);
                    await _db.SaveChangesAsync();
                    var empcheck = await _db.Employees.Where(x => x.Employee_type_Id == 1).FirstOrDefaultAsync(p => p.Address_store_Id == orderDto.Address_store_Id);
                    if (empcheck != null)
                    {
                        Order_handler oh = new Order_handler()
                        {
                            Address_store_Id = orderDto.Address_store_Id,
                            Order_Id = order.Id,
                            Employee_Id = empcheck.Id,
                            StatusHandle = true
                        };
                        _db.Order_handler.Add(oh);
                        await _db.SaveChangesAsync();
                    }

                    return new()
                    {
                        Status = true,
                        Message = "Create Order successfully!"
                    };
                }
                else
                {
                    return new()
                    {
                        Status = false,
                        Message = "fail"
                    };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException?.Message);
                return new()
                {
                    Status = false,
                    Message = ex.InnerException?.Message
                };
            }
        }



        public async Task<IEnumerable<OrderRes>> GetAll()
        {
            var orderList = await _db.Order.ToListAsync();
            var resList = new List<OrderRes>();
            foreach (var order in orderList)
            {
                resList.Add(_mapper.Map<OrderRes>(order));
            }
            return resList;
        }

        public async Task<DtoResult<List<OrderSummary>>> summary(int userID)
        {
            try
            {
                var ol = await _db.Order.Where(x => x.User_Id == userID).ToListAsync();

                var res = new List<OrderSummary>();
                foreach (var o in ol)
                {
                    var order = await _db.Order.FirstOrDefaultAsync(u => u.Id == o.Id);
                    var user = await _db.Users.FirstOrDefaultAsync(x => x.Id == o.User_Id);
                    var dura = await _db.Durations.FirstOrDefaultAsync(d => d.Id == o.Duration_Id);
                    var cou = await _db.Coupon.FirstOrDefaultAsync(c => c.Id == o.Coupon_Id);
                    var pack = await _db.Packages.FirstOrDefaultAsync(p => p.Id == dura.Package_Id);
                    var con = await _db.Connect_types.FirstOrDefaultAsync(n => n.Id == pack.Connect_type_Id);
                 
                        OrderSummary sum = new OrderSummary()
                        {
                            OrderId = order.Id,
                            CreatedDate = order.CreatedDate,
                            FullName = user.FullName,
                            Phone = user.Phone,
                            ConnectTypeName = con.Name,
                            PackageName = pack.Name,
                            DurationTime = dura.Time,
                            Validate = dura.Validate,
                            PackagePrice = dura.Price,
                            Deposit = con.Security_Deposit,
                            Coupon = cou.Percent_discount,
                            Tax = order.Tax,
                            TotalPrice = order.Total_Price,
                            Status = order.Status

                        }; res.Add(sum);
                    }



                }

                return new()
                {
                    Status = true,

                    Model = res
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


        public async Task<DtoResult<OrderRes>> Edit(OrderRes orderRes)
        {
            try
            {
                var coup = await _db.Order.FirstOrDefaultAsync(
                    c => c.Id.Equals(orderRes.Id));
                if (coup != null)
                {
                    coup.Status = orderRes.Status;
                    coup.Tax = orderRes.Tax;
                    await _db.SaveChangesAsync();
                    return new()
                    {
                        Status = true,
                        Message = "Update successfully"
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

        public async Task<DtoResult<OrderDto>> Delete(string id)
        {
            try
            {
                var coup = await _db.Order.FirstOrDefaultAsync(x => x.Id == id);
                if (coup != null)
                {
                    _db.Order.Remove(coup);
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



    }
}
