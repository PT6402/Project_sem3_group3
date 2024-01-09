using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Interface.IRepo;
using Lib.Dto.DurationDetail;
using Lib.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers.DurationCallChargeController
{
    [Route("api/[controller]")]
    public class DurationCallChargeController : Controller
    {
        private readonly IDurationCallCharge _detail;
        public DurationCallChargeController(IDurationCallCharge detail)
        {
            _detail = detail;
        }
        [HttpGet]
        public async Task<IEnumerable<Duration_callCharges>> Detail()
        {
            return await _detail.GetDuration_CallCharges();
        }

        [HttpPost]
        public async Task<IActionResult> Create(DurationDetailDto model)
        {
            Duration_callCharges res = new Duration_callCharges()
            {
                Duration_Id = model.Duration_Id,
                Call_charges_Id = model.Call_ChargeId
            };
            var check = await _detail.Create(res);
            if (check)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _detail.Remove(id);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(int id, DurationDetailDto model)
        {
            await _detail.Update(id, model);
            return Ok();
        }
    }
}

