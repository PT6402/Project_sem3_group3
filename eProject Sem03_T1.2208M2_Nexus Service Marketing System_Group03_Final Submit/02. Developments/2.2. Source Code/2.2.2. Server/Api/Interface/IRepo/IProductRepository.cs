using Lib.Dto;
using Lib.Dto.Product.Ctrl;

namespace Api.Interface.IRepo
{
    public interface IProductRepository
    {
        Task<DtoResult<ProductDto>> Create(ProductDto productDto);
        Task<IEnumerable<ProductDto>> GetAll();
        Task<IEnumerable<ProductDto>> GetBySupplier(int id);
        Task<IEnumerable<ProductDto>> GetByConnectType(int id);
        Task<DtoResult<ProductDto>> Edit(ProductDto productDto);
        Task<DtoResult<ProductDto>> DeleteProduct(int id);
    }
}
