using System;
using Lib.Dto.CallCharge;
using Lib.Entities;

namespace Api.Interface.IRepo
{
	public interface ICallCharge
	{
        Task<List<Call_charges>> GetCall_Charges();
        Task<bool> Create(Call_charges model);
        Task<bool> Remove(int id);
        Task<bool> Update(int id, CallChargeDto model);
    }
}

