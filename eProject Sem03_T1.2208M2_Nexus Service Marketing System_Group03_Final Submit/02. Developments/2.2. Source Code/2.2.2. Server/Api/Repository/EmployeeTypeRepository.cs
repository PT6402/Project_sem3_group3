using System;
using Api.Data_helper;
using Api.Interface.IRepo;
using AutoMapper;
using Lib.Dto;
using Lib.Dto.Coupon;
using Lib.Dto.Employee_TypeDto;
using Lib.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Repository
{
	public class EmployeeTypeRepository : IEmployeeType
	{
        private readonly DatabaseContext _db;
        private readonly IMapper _mapper;
        public EmployeeTypeRepository(DatabaseContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<List<Employee_typeDto>> GetEmployee_Types()
		{
            var emptype = await _db.Employee_types.ToListAsync();
            var res = new List<Employee_typeDto>();
            foreach (var e in emptype)
            {
                res.Add(_mapper.Map<Employee_typeDto>(e));
            }
            return res;
        }

        public async Task<DtoResult<Employee_typeDto>> Create(Employee_typeDto coupon)
        {
            try
            {
                Employee_type newEmptype = new Employee_type()
                {
                    Name = coupon.Name,
                    
                };
                _db.Employee_types.Add(newEmptype);
                await _db.SaveChangesAsync();
                return new()
                {
                    Status = true,
                    Message = "Create successfully"
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

        public async Task<DtoResult<Employee_typeDto>> Delete(int id)
        {
            try
            {
                var EmpType = await _db.Employee_types.FirstOrDefaultAsync(x => x.Id == id);
                if (EmpType != null)
                {
                    _db.Employee_types.Remove(EmpType);
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

