using Api.Interface.IRepo;
using Lib.Dto.Supplier.Ctrl;
using Lib.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Twilio.TwiML.Voice;

namespace Api.Controllers.Suppliers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private ISupplierRepository _supplier;
        public SupplierController(ISupplierRepository supplier)
        {
            _supplier = supplier;
        }

        [HttpPost]
        public async Task<IActionResult> Create(SupplierDto model)
        {
            var check = await _supplier.Create(model);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }

        [HttpGet]
        public async Task<IEnumerable<SupplierDto>> GetAll()
        {
            return await _supplier.GetAll();
        }

        [HttpGet("id")]
        public async Task<SupplierDto> GetById(int id)
        {
            return await _supplier.GetById(id);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(SupplierDto model)
        {
            var check = await _supplier.Edit(model);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteSup(int id)
        {
            var check = await _supplier.DeleteSup(id);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }
    }
}
