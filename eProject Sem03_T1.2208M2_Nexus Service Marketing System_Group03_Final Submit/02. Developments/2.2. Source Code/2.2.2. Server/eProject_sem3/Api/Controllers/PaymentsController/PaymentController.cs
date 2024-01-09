using Api.Interface.IRepo;
using Lib.Dto.Payment;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.PaymentsController
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentRepository _payment;
        public PaymentController(IPaymentRepository payment)
        {
            _payment = payment;
        }

        [HttpGet]
        public async Task<IEnumerable<PaymentDto>> GetAll()
        {
            return await _payment.GetAll();
        }

        [HttpPost]
        public async Task<IActionResult> Create(PaymentDto payment)
        {
            var check = await _payment.Create(payment);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(PaymentDto payment)
        {
            var check = await _payment.Update(payment);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }

        [HttpDelete]
        public async Task<IActionResult> Edit(int id)
        {
            var check = await _payment.Delete(id);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }
        [HttpGet("{Phone}")]
        public async Task<IActionResult> Paycheck(string Phone)
        {
            var check = await _payment.checkPayment(Phone);
            if (check.Status)
            {
                return Ok(check);
            }
            return BadRequest(check.Message);
        }
        [HttpPost("/checkinvoice")]
        public async Task<IActionResult> checkInvoice(PayDateCheck paydate)
        {
            var check = await _payment.Daycheck(paydate);
            if (check.Status)
            {
                return Ok(check.Model);
            }
            return BadRequest(check.Message);
        }
    }
}
