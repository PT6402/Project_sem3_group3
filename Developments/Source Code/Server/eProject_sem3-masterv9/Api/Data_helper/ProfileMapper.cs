

using AutoMapper;
using Lib.Dto.Address;
using Lib.Dto.Banner;
using Lib.Dto.Coupon;
using Lib.Dto.Duration;
using Lib.Dto.Employee_TypeDto;
using Lib.Dto.EmployeeDto;
using Lib.Dto.OrderHandler;
using Lib.Dto.Orders;
using Lib.Dto.Payment;
using Lib.Dto.Supplier.Ctrl;
using Lib.Dto.User.Ctrl.Req;
using Lib.Dto.User.Ctrl.Res;
using Lib.Dto.User.Repo;
using Lib.Entities;

namespace Lib.Mapper
{
    public class ProfileMapper : Profile
    {
        public ProfileMapper()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserSignUp, UserDto>();
            CreateMap<UserLogin, UserDto>();
            CreateMap<UserDto, UserRes>();
            CreateMap<Addresses, AddressDto>();
            CreateMap<Coupon, CouponDto>();
            CreateMap<Employee_type, Employee_typeDto>();
            CreateMap<Order, OrderRes>();
            CreateMap<Payment, PaymentDto>();
            CreateMap<Duration, DurationDto>();
            CreateMap<Supplier, SupplierDto>();
            CreateMap<User, UserShow>();
            CreateMap<Employee, EmployeeDto>();
            CreateMap<Address_store, AddressStoreDto>();
            CreateMap<Address_store, AddressDto>();
            CreateMap<Banner, BannerDto>();
            CreateMap<Duration, DurationInfo>();
            CreateMap<Order_handler, OrderHandlerDto>();
        }
    }
}
