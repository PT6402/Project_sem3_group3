using Api.Interface.IRepo;
using Lib.Dto.Product.Ctrl;
using Lib.Dto.Stories;
using Lib.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Stories
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImportReceiptController : ControllerBase
    {
        private readonly IImportReceiptRepository _stories;
        public ImportReceiptController(IImportReceiptRepository stories)
        {
            _stories = stories;
        }

        [HttpPost]
        public async Task<IActionResult> Create(StoriesReq pro)
        {
            var check = await _stories.Create(pro);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }

        [HttpGet]
        public async Task<IEnumerable<StoriesDto>> GetAll()
        {
            return await _stories.GetAll();
        }

        [HttpGet("product-id/address_store_id")]
        public async Task<IEnumerable<StoriesRes>> GetProductByAddressStore(int address_store_id)
        {
            return await _stories.GetProductByAddressStore(address_store_id);
        }

        [HttpGet("datetime/id")]
        public async Task<IEnumerable<StoriesDto>> GetBytime(DateTime time)
        {
            return await _stories.GetByTime(time);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(StoriesDto model)
        {
            var check = await _stories.Edit(model);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var check = await _stories.DeleteStories(id);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }
    }
}
