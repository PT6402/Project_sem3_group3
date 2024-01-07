using Api.Interface.IRepo;
using Lib.Dto;
using Lib.Dto.Coupon;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Coupons
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponController : ControllerBase
    {
        private readonly ICouponRepository _coupon;
        public CouponController(ICouponRepository coupon)
        {
            _coupon = coupon;
        }

        [HttpGet]
        public async Task<IEnumerable<CouponDto>> GetAll()
        {
            return await _coupon.GetAll();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CouponDto model)
        {
            var check = await _coupon.Create(model);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCoup(CouponDto model)
        {
            var check = await _coupon.Edit(model);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }

        [HttpDelete]
        public async Task<IActionResult> Delele(int id)
        {
            var check = await _coupon.DeleteCoupon(id);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }
    }
}
