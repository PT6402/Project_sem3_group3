using Api.Interface.IRepo;
using Lib.Dto.Product.Ctrl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Products
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _product;
        public ProductController(IProductRepository product)
        {
            _product = product;
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductDto pro)
        {
            var check = await _product.Create(pro);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }

        [HttpGet]
        public async Task<IEnumerable<ProductDto>> GetAll()
        {
            return await _product.GetAll();
        }

        [HttpGet("connect-type/id")]
        public async Task<IEnumerable<ProductDto>> GetByConnectType(int id)
        {
            return await _product.GetByConnectType(id);
        }

        [HttpGet("supplier/id")]
        public async Task<IEnumerable<ProductDto>> GetBySupplier(int id)
        {
            return await _product.GetBySupplier(id);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(ProductDto pro)
        {
            var check = await _product.Edit(pro);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var check = await _product.DeleteProduct(id);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }
    }
}
