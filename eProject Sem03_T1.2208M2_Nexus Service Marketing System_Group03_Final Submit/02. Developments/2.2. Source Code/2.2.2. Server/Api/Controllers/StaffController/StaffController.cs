using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Interface.IRepo;
using Lib.Dto;
using Lib.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers.StaffController
{
    [Route("api/[controller]")]
    public class StaffController : Controller
    {
       
            private readonly IStaff _staff;
            public StaffController(IStaff staff)
            {
                _staff = staff;
            }
            // GET: api/values
            [HttpGet]
            public async Task<ActionResult<DtoResult<List<Order_handler>>>> showOrder(int storeID,int empID)
            {
                var check = await _staff.GetOrderHandle(storeID,empID);
                if (check.Status)
                {
                    return Ok(check);
                }
                return BadRequest(check.Message);
            }
        }
    }


