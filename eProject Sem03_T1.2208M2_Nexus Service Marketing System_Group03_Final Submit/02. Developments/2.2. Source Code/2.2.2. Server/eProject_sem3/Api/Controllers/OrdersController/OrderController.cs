using Api.Interface.IRepo;
using Lib.Dto;
using Lib.Dto.Orders;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.OrdersController
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _order;
        public OrderController(IOrderRepository order)
        {
            _order = order;
        }

        [HttpPost]
        public async Task<IActionResult> Create(OrderDto model)
        {
            var check = await _order.Create(model);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            else
            {
                return BadRequest(check.Message);
            }
        }

        [HttpGet]
        public async Task<IEnumerable<OrderRes>> GetAll()
        {
            return await _order.GetAll();
        }

        [HttpGet("summary")]
        public async Task<ActionResult<DtoResult<List<OrderSummary>>>>showSummary(int userID)
        {
            var check = await _order.summary(userID);
            if(check.Status)
            {
                if(check.Model!=null)
                {
                    return Ok(check.Model);
                }
                return Ok(null);
            }return BadRequest(check.Message);
        }


        [HttpPut]
        public async Task<IActionResult> Edit(OrderRes model)
        {
            var check = await _order.Edit(model);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(string id)
        {
            var check = await _order.Delete(id);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }
    }
}
