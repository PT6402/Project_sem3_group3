using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Interface.IRepo;
using Lib.Dto.Duration;
using Lib.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers.DurationController
{
    [Route("api/[controller]")]
    public class DurationController : Controller
    {
        private readonly IDuration _duration;
        public DurationController(IDuration duration)
        {
            _duration = duration;
        }


        // GET api/values/5
        [HttpGet]
        public async Task<IEnumerable<DurationDto>> Detail()
        {

            return await _duration.GetDurations();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] DurationDto model)
        {
            var check = await _duration.Create(model);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete( int id)
        {
            await _duration.Remove(id);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] DurationDto model)
        {
            var check = await _duration.Update(model);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }

        [HttpGet("info")]
        public async Task<IEnumerable<DurationInfo>> GetInfo()
        {
            return await _duration.GetInfor();
        }
    }
}

