using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Interface.IRepo;
using Lib.Dto.Coupon;
using Lib.Dto.EmployeeDto;
using Lib.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers.EmployeeController
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployee _emp;
        public EmployeeController(IEmployee emp)
        {
            _emp = emp;
        }
      
        [HttpGet]
        public async Task<IActionResult> Detail()
        {
            var list= await _emp.GetEmployees();
            return Ok(list);
        }

      

        // POST api/values
        [HttpPost]
        public async Task<IActionResult>Create([FromBody] EmployeeDto req)
        {
            var Emp = await _emp.CreateEmp(req);
            if (Emp != null)
            {
                return Ok(Emp);
            }
            return BadRequest(Emp);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] EmployeeDto model)
        {
            var check = await _emp.Edit(model);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }

        [HttpDelete]
        public async Task<IActionResult> Delele( int id)
        {
            var check = await _emp.Delete(id);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }
    }
}

