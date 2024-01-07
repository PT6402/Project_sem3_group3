using System;
using Api.Data_helper;
using Api.Interface.IRepo;
using AutoMapper;
using Lib.Dto;

using Lib.Dto.Orders;

using Microsoft.EntityFrameworkCore;

namespace Api.Repository
{
    public class StaffRepository : IStaff
    {
        private readonly DatabaseContext _db;
        private readonly IMapper _mapper;
        public StaffRepository(DatabaseContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<DtoResult<List<StaffOrder>>> GetOrderHandle(int storeID, int empID)
        {
            try
            {

                var listoh = await _db.Order_handler.Where(x => x.Address_store_Id == storeID && x.StatusHandle == true)

                    .ToListAsync();
                var res = new List<StaffOrder>();
                foreach (var u in listoh)
                {
                    var order = await _db.Order.FirstOrDefaultAsync(x => x.Id == u.Order_Id);
                    if (order != null)
                    {
                        var dur = await _db.Durations.FirstOrDefaultAsync(x => x.Id == order.Duration_Id);
                        var pac = await _db.Packages.Include(o => o.Connect_type).FirstOrDefaultAsync(x => x.Id == dur.Package_Id);
                        var user = await _db.Users.FirstOrDefaultAsync(e => e.Id == order.User_Id);
                        var add = await _db.Address.FirstOrDefaultAsync(a => a.Id == order.Addresses_Id);
                        StaffOrder stafforder = new StaffOrder()
                        {
                            FullName = user.FullName,
                            Phone = user.Phone,
                            Order_Id = order.Id,
                            ConnectType = pac.Connect_type.Name,
                            Total_Price = order.Total_Price,
                            Numb_Connect = order.Numb_Connect,
                            Address_full = add.Address_full,
                            Phone_code = add.Phone_code,
                            Province_code = add.Province_code,
                            District_code = add.District_code,
                            Ward_code = add.Ward_code,
                            Time = dur.Time,
                            Validate = dur.Validate,
                            Status = order.Status,
                            DateCreate = order.CreatedDate
                        }; res.Add(stafforder);
                    }

                }
                var empcheck = await _db.Employees.FirstOrDefaultAsync(x => x.Id == empID);
                if (empcheck != null && empcheck.Employee_type_Id == 1)
                {
                    res = res.Where(x => x.Status != "Finish").ToList();
                }
                if (empcheck != null && empcheck.Employee_type_Id == 2)
                {
                    res = res.Where(x => x.Status == "Confirmed").ToList();
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


    }
}

