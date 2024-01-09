using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Interface.IRepo;
using Lib.Dto.ConnectType;
using Lib.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers.ConnectTypeController
{
    [Route("api/[controller]")]
    public class ConnectTypeController : Controller
    {
        private readonly IConnectType _connect;
        public ConnectTypeController(IConnectType connect)
        {
            _connect = connect;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ConnectTypeRes model)
        {
            var check = await _connect.Create(model);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }

        [HttpGet]
        public async Task<IEnumerable<ConnectTypeDto>> Detail()
        {

            return await _connect.GetConnect_Types();
        }

        [HttpDelete]
        public async Task<IActionResult> Delelte( int id)
        {
            await _connect.Remove(id);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] ConnectTypeRes model)
        {
            var check = await _connect.Update(model);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }
    }
}

