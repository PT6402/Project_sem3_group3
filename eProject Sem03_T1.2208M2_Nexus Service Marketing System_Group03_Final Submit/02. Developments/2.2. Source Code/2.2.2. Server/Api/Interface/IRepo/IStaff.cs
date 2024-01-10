using System;
using Lib.Dto;
using Lib.Dto.Orders;

namespace Api.Interface.IRepo
{
	public interface IStaff
	{
        Task<DtoResult<List<StaffOrder>>> GetOrderHandle(int storeID, int empID);
    }
}

