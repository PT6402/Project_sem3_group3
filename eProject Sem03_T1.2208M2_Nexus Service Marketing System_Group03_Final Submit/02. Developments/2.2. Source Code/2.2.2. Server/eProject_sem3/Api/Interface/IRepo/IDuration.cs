using System;
using Lib.Dto;
using Lib.Dto.Duration;
using Lib.Entities;

namespace Api.Interface.IRepo
{
	public interface IDuration
	{
        Task<List<DurationDto>> GetDurations();
        Task<DtoResult<DurationDto>> Create(DurationDto model);
        Task<bool> Remove(int id);
        Task<DtoResult<DurationDto>> Update(DurationDto model);
        Task<IEnumerable<DurationInfo>> GetInfor();
    }
}

