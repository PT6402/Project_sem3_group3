using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Interface.IRepo;
using Lib.Dto.Coupon;
using Lib.Dto.Employee_TypeDto;
using Lib.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers.EmployeeTypeController
{
    [Route("api/[controller]")]
    public class EmployeeTypeController : Controller
    {
        private readonly IEmployeeType _emptype;
        public EmployeeTypeController(IEmployeeType emptype)
        {
            _emptype = emptype;
        }
        // GET: api/values
        [HttpGet]
        public async Task<IEnumerable<Employee_typeDto>> GetAll()
        {
            return await _emptype.GetEmployee_Types();
        }



        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Employee_typeDto model)
        {
            var check = await _emptype.Create(model);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }


        [HttpDelete]
        public async Task<IActionResult> Delele(int id)
        {
            var check = await _emptype.Delete(id);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }
    }
}

