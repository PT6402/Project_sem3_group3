using System;
using Lib.Dto.DurationDetail;
using Lib.Entities;

namespace Api.Interface.IRepo
{
	public interface IDurationCallCharge
	{
        Task<List<Duration_callCharges>> GetDuration_CallCharges();
        Task<bool> Create(Duration_callCharges model);
        Task<bool> Remove(int id);
        Task<bool> Update(int id, DurationDetailDto model);
    }
}

