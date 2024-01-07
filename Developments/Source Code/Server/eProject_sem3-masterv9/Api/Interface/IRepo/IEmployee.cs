using System;
using Lib.Dto;
using Lib.Dto.EmployeeDto;

namespace Api.Interface.IRepo
{
	public interface IEmployee
	{
        Task<string> CreateEmp(EmployeeDto model);
        Task<IEnumerable<EmployeeDto>> GetEmployees();
        Task<DtoResult<EmployeeDto>> Delete(int id);
        Task<DtoResult<EmployeeDto>> Edit(EmployeeDto model);
    }
}

