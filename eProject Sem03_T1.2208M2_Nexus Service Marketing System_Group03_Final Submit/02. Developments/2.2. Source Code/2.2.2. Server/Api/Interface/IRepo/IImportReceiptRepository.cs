using Lib.Dto.Stories;
using Lib.Dto;
using Lib.Dto.Product.Ctrl;

namespace Api.Interface.IRepo
{
    public interface IImportReceiptRepository
    {
        Task<DtoResult<StoriesDto>> Create(StoriesReq model);
        Task<IEnumerable<StoriesDto>> GetAll();
        Task<IEnumerable<StoriesRes>> GetProductByAddressStore(int id);
        Task<IEnumerable<StoriesDto>> GetByTime(DateTime time);
        Task<DtoResult<StoriesDto>> Edit(StorageRequest model);
        Task<DtoResult<StoriesDto>> ExportProduct(StoriesReq model);
        Task<DtoResult<StoriesDto>> DeleteStories(int id);
        Task<DtoResult<List<ProductDto>>> checkNotPro(int Address_Store_Id);
        Task<IEnumerable<ProductRes>> CheckProductByAddressStore(string orderId, int addresStoreId);


    }
}
