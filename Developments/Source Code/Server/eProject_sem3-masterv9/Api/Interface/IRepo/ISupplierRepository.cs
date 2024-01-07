using Lib.Dto;
using Lib.Dto.Supplier.Ctrl;
using Lib.Entities;

namespace Api.Interface.IRepo
{
    public interface ISupplierRepository
    {
        Task<DtoResult<SupplierDto>> Create(SupplierDto model);
        Task<IEnumerable<SupplierDto>> GetAll();
        Task<SupplierDto> GetById(int id);
        Task<DtoResult<SupplierDto>> Edit(SupplierDto model);
        Task<DtoResult<SupplierDto>> DeleteSup(int id);
    }
}
