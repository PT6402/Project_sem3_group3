using Lib.Dto;
using Lib.Dto.Banner;
using Lib.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api.Interface.IRepo
{
    public interface IBannerRepository
    {
        Task<IEnumerable<BannerDto>> GetAll();
        Task<DtoResult<BannerDto>> Create([FromForm]BannerDto model, IFormFile file);
        Task<DtoResult<BannerDto>> Update(BannerDto model);
        Task<DtoResult<BannerDto>> Delete(int id);
    }
}
