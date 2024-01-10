using Api.Interface.IRepo;
using Lib.Dto.Address;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Address_Full
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressRepository _address;
        public AddressController(IAddressRepository address)
        {
            _address = address;
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddressDto model)
        {
            var check = await _address.Create(model);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }

        [HttpGet]
        public async Task<IEnumerable<AddressDto>> GetAll()
        {
            return await _address.GetAll();
        }

        [HttpGet("city")]
        public async Task<IEnumerable<AddressDto>> GetByCity(string city)
        {
            return await _address.GetByCity(city);
        }

        [HttpGet("district")]
        public async Task<IEnumerable<AddressDto>> GetByDistrict(string district)
        {
            return await _address.GetByDistrict(district);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(AddressDto model)
        {
            var check = await _address.EditAddress(model);
            if(check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAddress(int id)
        {
            var check = await _address.DeleteAddress(id);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }
    }
}
