using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Interface.IRepo;
using Lib.Dto.Address;
using Lib.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers.AddressStoreController
{
    [Route("api/[controller]")]
    public class AddressStoreController : Controller
    {
        private readonly IAddressStore _addressstore;
        public AddressStoreController(IAddressStore addressStore)
        {
            _addressstore = addressStore;
        }

        [HttpGet]
        public async Task<IEnumerable<AddressDto>>Detail()
        {

            return await _addressstore.GetAddress_Stores();
            /*var result=list.Select(x => new
            {
                    Id=x.Id,
                    Address=x.Addresses.Address_full,
                    Phone_code = x.Addresses.Phone_code,
                    Province_code = x.Addresses.Province_code,
                    District_code = x.Addresses.District_code,
                    Ward_code = x.Addresses.Ward_code
            });
            return Ok( result);*/
        }
      

        [HttpPost]
        public async Task<IActionResult>Create([FromBody]AddressDto model)
        {
            /*Addresses res = new Addresses()
            {
                Address_full = model.Address_full,
                Phone_code = model.Phone_code,
                Province_code = model.Province_code,
                District_code = model.District_code,
                Ward_code = model.Ward_code
            };*/
            var check = await _addressstore.Create(model);
            if(check=="true")
            {
                return Ok();
            }
            else { return BadRequest(check); }
        }

        [HttpPut]
        public async Task<IActionResult> Edit([FromBody] AddressDto model)
        {
            var check = await _addressstore.Edit(model);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAddress(int id)
        {
            var check = await _addressstore.Delete(id);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }

        [HttpPost("stores")]
        public async Task<IEnumerable<AddressDto>> GetStore([FromBody]AddressStoreSearch model)
        {
            return await _addressstore.GetStore(model);
        }
    }
}

