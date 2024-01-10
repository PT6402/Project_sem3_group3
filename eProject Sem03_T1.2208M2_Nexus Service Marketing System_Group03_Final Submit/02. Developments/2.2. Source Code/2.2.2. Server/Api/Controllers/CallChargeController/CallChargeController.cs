using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Interface.IRepo;
using Lib.Dto.CallCharge;
using Lib.Dto.Duration;
using Lib.Dto.Package;
using Lib.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers.CallChargeController
{
    [Route("api/[controller]")]
    public class CallChargeController : Controller
    {
        private readonly ICallCharge _callcharge;
        public CallChargeController(ICallCharge callCharge)
        {
            _callcharge = callCharge;
        }

        [HttpGet]
        public async Task<IEnumerable<Call_charges>> Detail()
        {
            return await _callcharge.GetCall_Charges();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CallChargeDto model)
        {
             Call_charges newpack = new Call_charges()
            {
                Name = model.Name,
                Unit=model.Unit,
                Price=model.Price
            };
            var check = await _callcharge.Create(newpack);
            if (check)
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _callcharge.Remove(id);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(int id, CallChargeDto model)
        {
            await _callcharge.Update(id, model);
            return Ok();
        }
    }
}

