using Lib.Dto;
using Lib.Dto.Coupon;

namespace Api.Interface.IRepo
{
    public interface ICouponRepository
    {
        Task<DtoResult<CouponDto>> Create(CouponDto coupon);
        Task<IEnumerable<CouponDto>> GetAll();
        Task<DtoResult<CouponDto>> Edit(CouponDto coupon);
        Task<DtoResult<CouponDto>> DeleteCoupon(int id);
    }
}
