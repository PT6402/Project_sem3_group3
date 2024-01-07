using System;
using Lib.Dto;
using Lib.Dto.ConnectType;
using Lib.Entities;

namespace Api.Interface.IRepo
{
	public interface IConnectType
	{
        Task<DtoResult<ConnectTypeRes>> Create(ConnectTypeRes model);
        Task<List<ConnectTypeDto>> GetConnect_Types();
        Task<bool> Remove(int id);
        Task<DtoResult<ConnectTypeRes>> Update(ConnectTypeRes model);
    }
}

