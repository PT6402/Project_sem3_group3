using System;
using Api.Data_helper;
using Api.Interface.IRepo;
using Api.Interface.IService;
using AutoMapper;
using Lib.Dto;
using Lib.Dto.Coupon;
using Lib.Dto.EmployeeDto;
using Lib.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Repository
{
	public class EmployeeRepository:IEmployee
	{
		private readonly DatabaseContext _db;
		private readonly IPassword _pass;
        private readonly IMapper _mapper;
        public EmployeeRepository(DatabaseContext db,IPassword pass,IMapper mapper)
		{
			_db = db;
			_pass = pass;
			_mapper = mapper;
		}


		public async Task<IEnumerable<EmployeeDto>> GetEmployees()
		{
			var list= await _db.Employees.ToListAsync();
            var res = new List<EmployeeDto>();
            foreach (var emptype in list)
            {
				var user=await _db.Users.FirstOrDefaultAsync(x => x.Id == emptype.User_Id);

                EmployeeDto newE = new EmployeeDto()
				{
					Phone = user.Phone,
					Email=user.Email,
					FullName=user.FullName,
					Id=emptype.Id,
					Employee_type_id=emptype.Employee_type_Id,
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
               
               
				if(check!=null)
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
                        Address_store_Id=model.Address_store_id

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
                        Address_store_Id=model.Address_store_id

                    };
                    await _db.AddAsync(newemp);
                    await _db.SaveChangesAsync();
                    return "true";
                }
				
			}catch(Exception ex)
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
                    user.FullName = model.FullName?? user.FullName;
                    user.Role = "Emp_" + Emptype!.Name;
                    user.Phone = model.Phone??user.Phone;
                    user.Email = model.Email?? user.Email;
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
    }
}

