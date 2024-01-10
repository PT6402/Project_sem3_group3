using Lib.Dto;
using Lib.Dto.Address;

namespace Api.Interface.IRepo
{
    public interface IAddressRepository
    {
        Task<DtoResult<AddressDto>> Create(AddressDto model);
        Task<IEnumerable<AddressDto>> GetAll();
        Task<IEnumerable<AddressDto>> GetByCity(string city);
        Task<IEnumerable<AddressDto>> GetByDistrict(string district);
        Task<DtoResult<AddressDto>> EditAddress(AddressDto model);
        Task<DtoResult<AddressDto>> DeleteAddress(int id);
    }
}
