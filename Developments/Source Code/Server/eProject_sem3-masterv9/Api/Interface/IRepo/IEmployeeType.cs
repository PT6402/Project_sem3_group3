using System;
using Lib.Dto;
using Lib.Dto.Employee_TypeDto;

namespace Api.Interface.IRepo
{
	public interface IEmployeeType
	{
        Task<List<Employee_typeDto>> GetEmployee_Types();
        Task<DtoResult<Employee_typeDto>> Create(Employee_typeDto coupon);
        Task<DtoResult<Employee_typeDto>> Delete(int id);

    }
}

