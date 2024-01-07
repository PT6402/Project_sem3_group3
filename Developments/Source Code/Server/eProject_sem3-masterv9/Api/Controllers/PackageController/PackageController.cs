using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Interface.IRepo;
using Lib.Dto.Package;
using Lib.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers.PackageController
{
    [Route("api/[controller]")]
    public class PackageController : Controller
    {
        private readonly IPackage _package;
        public PackageController(IPackage package)
        {
            _package = package;
        }
        // GET: api/values
        [HttpGet]
        public async Task<IEnumerable<PackageDto>> Detail()
        {
            return await _package.GetPackages();
        }



        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PackageRes model)
        {
            var check = await _package.Create(model);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }

        // PUT api/values/5
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] PackageEdit model)
        {
            var check = await _package.Update(model);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }

        // DELETE api/values/5
        [HttpDelete]
        public async Task<IActionResult> Delelte( int id)
        {
            await _package.Remove(id);
            return Ok();
        }
    }
}

