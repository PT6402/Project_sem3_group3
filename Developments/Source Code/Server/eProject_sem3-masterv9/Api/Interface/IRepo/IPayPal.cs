using System;
using Lib.Entities;
using PayPal.Api;
namespace Api.Interface.IRepo
{
    public interface IPayPal
    {
        Task<PayPal.Api.Payment> CreatePayment(HttpContext httpContext, decimal amount, string currency, string returnUrl, string cancelUrl);

        Task<PayPal.Api.Payment> ExecutePayment(HttpContext httpContext, string payerId, string paymentId);

    }
}

