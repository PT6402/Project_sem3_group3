using System;
using Lib.Dto;
using Lib.Dto.Address;
using Lib.Entities;

namespace Api.Interface.IRepo
{
	public interface IAddressStore
	{
        Task<List<AddressDto>> GetAddress_Stores();
        Task<string> Create(AddressDto model);
        Task<DtoResult<AddressDto>> Edit(AddressDto model);
        Task<DtoResult<AddressStoreDto>> Delete(int id);
        Task<IEnumerable<AddressDto>> GetStore(AddressStoreSearch model);
    }
}

