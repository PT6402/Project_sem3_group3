using Api.Interface.IRepo;
using Lib.Dto.Banner;
using Lib.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.BannersController
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannerController : ControllerBase
    {
        private readonly IBannerRepository _banner;
        public BannerController(IBannerRepository banner)
        {
            _banner = banner;
        }

        [HttpGet]
        public async Task<IEnumerable<BannerDto>> GetAll()
        {
            return await _banner.GetAll();
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromForm] BannerDto model, IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("Please provide a valid file");
            }

            var check = await _banner.Create(model, file);

            if (check.Status)
            {
                return Ok(check.Message);
            }

            return BadRequest(check.Message);
        }


        [HttpPut]
        public async Task<IActionResult> Edit (BannerDto model)
        {
            var check = await _banner.Update(model);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBanner(int id)
        {
            var check = await _banner.Delete(id);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }
    }
}
