using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Interface.IRepo;
using Lib.Dto.OrderHandler;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers.OrderHandlerController
{
    [Route("api/[controller]")]
    public class OrderHandlerController : Controller
    {
        private readonly IOrderHandler _order;
        public OrderHandlerController(IOrderHandler order)
        {
            _order = order;
        }
        // GET: api/values
        [HttpGet]
        public async Task<IEnumerable<OrderHandlerDto>>Detail()
        {
            return await _order.GetOrderHandlerDtos();
        }

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        }
    }


