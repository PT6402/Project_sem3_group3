using Lib.Dto.Stories;
using Lib.Dto;

namespace Api.Interface.IRepo
{
    public interface IImportReceiptRepository
    {
        Task<DtoResult<StoriesDto>> Create(StoriesReq model);
        Task<IEnumerable<StoriesDto>> GetAll();
        Task<IEnumerable<StoriesRes>> GetProductByAddressStore(int id);
        Task<IEnumerable<StoriesDto>> GetByTime(DateTime time);
        Task<DtoResult<StoriesDto>> Edit(StoriesDto model);
        Task<DtoResult<StoriesDto>> DeleteStories(int id);
    }
}
