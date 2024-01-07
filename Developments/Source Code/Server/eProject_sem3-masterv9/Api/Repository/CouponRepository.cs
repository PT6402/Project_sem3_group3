using Api.Data_helper;
using Api.Interface.IRepo;
using AutoMapper;
using Lib.Dto;
using Lib.Dto.Coupon;
using Lib.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Repository
{
    public class CouponRepository : ICouponRepository
    {
        private readonly DatabaseContext _db;
        private readonly IMapper _mapper;
        public CouponRepository(DatabaseContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }


        public async Task<DtoResult<CouponDto>> Create(CouponDto coupon)
        {
            try
            {
                Coupon newCoup = new Coupon()
                {
                    Name=coupon.name,
                    To=coupon.to,
                    From=coupon.from,
                    Percent_discount=coupon.percent_discount,
                };
                _db.Coupon.Add(newCoup);
                await _db.SaveChangesAsync();
                return new()
                {
                    Status = true,
                    Message = "Create successfully"
                };
            }
            catch (Exception ex)
            {
                return new()
                {
                    Status = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<DtoResult<CouponDto>> DeleteCoupon(int id)
        {
            try
            {
                var coup = await _db.Coupon.FirstOrDefaultAsync(x => x.Id == id);
                if (coup != null)
                {
                    _db.Coupon.Remove(coup);
                    await _db.SaveChangesAsync();
                    return new()
                    {
                        Status = true,
                        Message = "Delete successfully"
                    };
                }
                else
                {
                    return new()
                    {
                        Status = false,
                        Message = "Delete fail!"
                    };
                }
            }
            catch (Exception ex)
            {
                return new()
                {
                    Status = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<DtoResult<CouponDto>> Edit(CouponDto coupon)
        {
            try
            {
                var coup = await _db.Coupon.FirstOrDefaultAsync(
                    c => c.Id.Equals(coupon.id));
                if (coupon != null)
                {
                    coup.Name = coupon.name;
                    coup.To = coupon.to;
                    coup.From = coupon.from;
                    coup.Percent_discount = coupon.percent_discount;
                    await _db.SaveChangesAsync();
                    return new()
                    {
                        Status = true,
                        Message = "Update successfully"
                    };
                }
                return new()
                {
                    Status = false,
                    Message = "Update fail"
                };
            }
            catch (Exception ex)
            {
                return new()
                {
                    Status = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<IEnumerable<CouponDto>> GetAll()
        {
            var coupList = await _db.Coupon.ToListAsync();
            var res = new List<CouponDto>();
            foreach (var coup in coupList)
            {
                res.Add(_mapper.Map<CouponDto>(coup));
            }
            return res;
        }
    }
}
