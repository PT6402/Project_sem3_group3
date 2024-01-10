using Api.Interface.IRepo;
using Api.Interface.IService;
using Api.Service.Mail;
using Api.Service.Password;
using Api.Service.TimeProvider;
using Api.Service.Token;
using Lib.Entities;

namespace Api.Repository
{
    public static class DIRepo
    {
        public static IServiceCollection AddRepo(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ISupplierRepository, SupplierRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IImportReceiptRepository, ImportReceiptRepository>();
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<ICouponRepository, CouponRepository>();

            services.AddScoped<IConnectType, ConnectTypeRepository>();
            services.AddScoped<IPackage, PackageRepository>();
            services.AddScoped<IDuration, DurationRepository>();
            services.AddScoped<IDurationCallCharge, DurationCallChargeRepository>();
            services.AddScoped<ICallCharge, CallChargeRepository>();
            services.AddScoped<IAddressStore, AddressStoreRepository>();
            services.AddScoped<IEmployeeType, EmployeeTypeRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IPaymentRepository, PaymentRepository>();
            services.AddScoped<IEmployee, EmployeeRepository>();
            services.AddScoped<IBannerRepository, BannerRepository>();
            services.AddScoped<IOrderHandler, OrderHandlerRepository>();
            services.AddScoped<IStaff, StaffRepository>();
            services.AddScoped<IPayPal, PayPalRepository>();
            return services;
        }
    }
}
