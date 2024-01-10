using System.Runtime.ConstrainedExecution;
using Api.Data_helper;
using Api.Interface.IRepo;
using AutoMapper;
using Lib.Dto;
using Lib.Dto.Payment;
using Lib.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Repository
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly DatabaseContext _db;
        private readonly IMapper _mapper;
        public PaymentRepository(DatabaseContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<DtoResult<PaymentDto>> Create(PaymentDto model)
        {
            try
            {
                //first letter
                string id = model.Order_Id;
                var connectTypeFirstLetter = _db.Order
                .Where(d => d.Id == id)
                .Select(d => d.Duration!.Package!.Connect_type!.First_Letter)
                .FirstOrDefault();

                //phone code
                var phoneCode = _db.Order
                .Where(d => d.Id == id)
                .Select(d => d.Addresses!.Phone_code)
                .FirstOrDefault();
                if (phoneCode!.Length < 3)
                {
                    phoneCode = "0" + phoneCode;
                }
                //count order
                var listOrder = await _db.Order.ToListAsync();
                var count = listOrder.Count();
                var formattedCount = count.ToString().PadLeft(12, '0');

                //user id
                /* var user_id = await _db.Order
                 .Where(d => d.Id == id)
                 .Select(d => d.User_Id)
                 .FirstOrDefaultAsync();*/
                var orders = await _db.Order.FirstOrDefaultAsync(o => o.Id == model.Order_Id);
                var userId = await _db.Users.FirstOrDefaultAsync(u => u.Id == orders.User_Id);
                Payment payment = new Payment()
                {
                    Order_Id = model.Order_Id,
                    Method_Payment = model.Method_Payment,
                    Status = model.Status
                };
                _db.Payment.Add(payment);
                await _db.SaveChangesAsync();
                var checkuser = await _db.TP_contract.FirstOrDefaultAsync(x => x.User_Id == userId.Id);
                if (checkuser != null && payment.Status == true)
                {
                    Contract_Service contract_Service = new Contract_Service()
                    {
                        Id = connectTypeFirstLetter + phoneCode + formattedCount,
                        Order_Id = model.Order_Id,
                        TP_Contract_Id = checkuser.Id,
                        ContractCode = connectTypeFirstLetter + phoneCode + formattedCount
                    };
                    _db.Contract_Services.Add(contract_Service);


                    var order = _db.Order.FirstOrDefault(x => x.Id == payment.Order_Id);
                    order.Status = "Paid";
                    await _db.SaveChangesAsync();

                }
                else
                {
                    TP_contract tP_Contract = new TP_contract()
                    {
                        Id = connectTypeFirstLetter + phoneCode + formattedCount,
                        User_Id = userId.Id
                    };
                    _db.TP_contract.Add(tP_Contract);
                    await _db.SaveChangesAsync();

                    Contract_Service contract_Service = new Contract_Service()
                    {
                        Id = connectTypeFirstLetter + phoneCode + formattedCount,
                        Order_Id = model.Order_Id,
                        TP_Contract_Id = tP_Contract.Id,
                        ContractCode = tP_Contract.Id
                    };
                    _db.Contract_Services.Add(contract_Service);
                    await _db.SaveChangesAsync();
                    var user = _db.Users.FirstOrDefault(x => x.Id.Equals(userId.Id));
                    user!.TP_contract_Id = tP_Contract.Id;
                    var order = _db.Order.FirstOrDefault(x => x.Id == payment.Order_Id);
                    order.Status = "Paid";
                    await _db.SaveChangesAsync();
                }




                return new()
                {
                    Status = true,
                    Message = "Payment successfully"
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

        public async Task<DtoResult<PaymentDto>> Delete(int id)
        {
            try
            {
                var model = await _db.Payment.FirstOrDefaultAsync(m => m.Id == id);
                if (model != null)
                {
                    _db.Remove(model);
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

        public async Task<IEnumerable<PaymentDto>> GetAll()
        {
            var list = await _db.Payment.ToListAsync();
            var res = new List<PaymentDto>();
            foreach (var item in list)
            {
                res.Add(_mapper.Map<PaymentDto>(item));
            }
            return res;
        }

        public async Task<DtoResult<PaymentDto>> Update(PaymentDto model)
        {
            try
            {
                var payment = await _db.Payment.FirstOrDefaultAsync(p => p.Id == model.Id);
                if (payment != null)
                {
                    payment.Order_Id = model.Order_Id;
                    payment.Method_Payment = model.Method_Payment;
                    payment.Status = model.Status;
                    await _db.SaveChangesAsync();
                    return new()
                    {
                        Status = true,
                        Message = "Update successfully"
                    };
                }
                else
                {
                    return new()
                    {
                        Status = false,
                        Message = "Update fail"
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

        public async Task<DtoResult<PaymentCheck>> checkPayment(string Phone)
        {
            try
            {
                var user = await _db.Users.FirstOrDefaultAsync(x => x.Phone == Phone);
                if (user != null)
                {
                    var checktp = await _db.TP_contract.FirstOrDefaultAsync(x => x.User_Id == user.Id);
                    if (checktp != null)
                    {
                        var checkcs = await _db.Contract_Services.Where(x => x.TP_Contract_Id == checktp.Id).ToListAsync();
                        if (checkcs.Any())
                        {
                            List<ServiceDto> listser = new();
                            checkcs.ForEach(x =>
                            {

                                var order = _db.Order.FirstOrDefault(o => o.Id == x.Order_Id);
                                var dura = _db.Durations.FirstOrDefault(a => a.Id == order.Duration_Id);

                                var pack = _db.Packages.FirstOrDefault(p => p.Id == dura.Package_Id);

                                var con = _db.Connect_types.FirstOrDefault(c => c.Id == pack.Connect_type_Id);

                                ServiceDto ser = new ServiceDto()
                                {
                                    Duration = dura.Time,
                                    Package = pack.Name,
                                    Connect_type = con.Name,
                                    Price = order.Total_Price,
                                    OrderId = order.Id,

                                };
                                listser.Add(ser);
                            });


                            PaymentCheck paym = new PaymentCheck()
                            {
                                Phone = user.Phone,
                                TP_Contract_Id = checktp.Id,
                                FullName = user.FullName,
                                ServiceDtos = listser,
                            };
                            return new()
                            {
                                Status = true,
                                Model = paym
                            };
                        }
                    }
                }
                return new()
                {
                    Status = false,
                    Message = "not found",
                };
            }
            catch (Exception ex)
            {
                return new()
                {
                    Status = false,
                    Message = ex.Message,
                };
            }

        }
        public async Task<DtoResult<List<PaymentListCheck>>> Daycheck(PayDateCheck dayInput)
        {
            try
            {
                var dayPay = await _db.Payment.Include(o => o.Order)
                    .Where(x => x.DateCreated.Date >= dayInput.FromDate.Date && x.DateCreated.Date <= dayInput.ToDate.Date && x.Order.User_Id == dayInput.User_Id)
        .ToListAsync();


                if (dayPay.Any())
                {
                    List<PaymentListCheck> list = new();
                    dayPay.ForEach(x =>
                    {
                        PaymentListCheck pay = new PaymentListCheck();
                        var next = _db.Order.FirstOrDefault(o => o.Id == x.Order_Id);
                        var duracheck = _db.Durations.FirstOrDefault(d => d.Id == next.Duration_Id);
                        DateTime nextpay = x.DateCreated.AddMonths(int.Parse(duracheck.Validate));
                        var contract = _db.Contract_Services.FirstOrDefault(c => c.Order_Id == next.Id);
                        pay.NextPay = nextpay;
                        pay.Contract_Service_Id = contract.Id;
                        pay.Last_payment_value = next.Total_Price;
                        list.Add(pay);

                    });

                    return new()
                    {
                        Status = true,
                        Model = list
                    };
                }
                return new()
                {
                    Status = false,
                    Message = "not found",
                };
            }
            catch (Exception ex)
            {
                return new()
                {
                    Status = false,
                    Message = ex.Message,
                };
            }
        }

    }
}

