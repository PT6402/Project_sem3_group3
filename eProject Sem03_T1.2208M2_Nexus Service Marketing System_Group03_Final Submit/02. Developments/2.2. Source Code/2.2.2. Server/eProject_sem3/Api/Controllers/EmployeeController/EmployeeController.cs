using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Interface.IRepo;
using Lib.Dto.Coupon;
using Lib.Dto.EmployeeDto;
using Lib.Dto.FeedbackSend;
using Lib.Dto.Product.Ctrl;
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

        [HttpPost("checkproduct")]
        public async Task<IActionResult> checkproduct([FromBody]checkProduct p)
        {
            var check = await _emp.CheckProduct(p);
            return Ok(check);
        }

        [HttpGet("checkStaffStatus")]
        public async Task<IActionResult> staffedit(string Order_Id)
        {
            var check = await _emp.StaffEditStatus(Order_Id);
            if (check)
            {
                return Ok("true");
            }
            return BadRequest();
        }

        [HttpGet("checkStatus")]
        public async Task<IActionResult> techedit(string Order_Id)
        {
            var check = await _emp.TechEditStatus(Order_Id);
            if (check)
            {
                return Ok("true");
            }
            return BadRequest();
        } 
        
        [HttpGet("checkStaffStatusPayment")]
        public async Task<IActionResult> staffCofirmPayment(string Order_Id)
        {
            var check = await _emp.StaffStatusPayment(Order_Id);
            if (check)
            {
                return Ok("true");
            }
            return BadRequest();
        }
        [HttpGet("StopOrder")]
        public async Task<IActionResult> stopOrder(string Order_Id)
        {
            var check = await _emp.StaffStopOrder(Order_Id);
            if (check)
            {
                return Ok("true");
            }
            return BadRequest();
        }

        [HttpPost("sendfeedback")]
        public async Task<IActionResult>SendFeedback([FromBody] SendDto send)
        {
            var check = await _emp.Sendfeed(send);
            if (check!=null)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }

        [HttpGet("seefeed")]
        public async Task<IActionResult>SeeFeed()
        {
            var list =await _emp.SeeFeed();
            return Ok(list);
        }

        [HttpPost("replyFeed")]
        public async Task<IActionResult> replyFeedback([FromBody]ReplyDto reply)
        {
            var check = await _emp.Replyfeed(reply);
            if (check != null)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }
    }
}

