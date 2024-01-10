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
        public async Task<IActionResult> Edit(StorageRequest model)
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

        [HttpPut("export_product")]
        public async Task<IActionResult> ExportProduct(StoriesReq model)
        {
            var check = await _stories.ExportProduct(model);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }

        [HttpGet("checknopro")]
        public async Task<IActionResult> checkNoPro(int Address_store_id)
        {
            var check = await _stories.checkNotPro(Address_store_id);
            if (check.Status)
            {
                return Ok(check);
            }
            return BadRequest(check.Message);
        }
        [HttpPost("check-pro-by-addressStore")]
        public async Task<IEnumerable<ProductRes>> CheckProductByAddressStore([FromBody]checkProduct request)
        {
            return await _stories.CheckProductByAddressStore(request.Order_Id, request.Address_Store_Id);
        }

    }
}
