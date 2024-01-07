using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stripe.Checkout;

using static System.Net.WebRequestMethods;
using Api.Data_helper;
using Microsoft.EntityFrameworkCore;
using Lib.Dto.Payment;

namespace Api.Controllers.StripeTest
{
    [Route("api/[controller]")]
    [ApiController]
    public class StripeController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private static string s_wasmClientURL = string.Empty;
        private readonly DatabaseContext _db;

        public StripeController(IConfiguration configuration, DatabaseContext db)
        {
            _configuration = configuration;
            _db = db;
        }
        [HttpGet("{Order_Id}")]
        public async Task<ActionResult> CheckoutOrder(string Order_Id, [FromServices] IServiceProvider sp)
        {
            var referer = Request.Headers.Referer;
            s_wasmClientURL = referer[0];

            // Build the URL to which the customer will be redirected after paying.
            var server = sp.GetRequiredService<IServer>();

            var serverAddressesFeature = server.Features.Get<IServerAddressesFeature>();

            string? thisApiUrl = null;

            if (serverAddressesFeature is not null)
            {
                thisApiUrl = serverAddressesFeature.Addresses.FirstOrDefault();
            }

            if (thisApiUrl is not null)
            {
                var order = await _db.Order.FirstOrDefaultAsync(x => x.Id == Order_Id);
                var du = await _db.Durations.FirstOrDefaultAsync(o => o.Id == order.Duration_Id);
                var price = (float)order.Total_Price * 100;
                PaymentInfo info = new PaymentInfo()
                {
                    Name = order.Id,
                    Price = Convert.ToInt32(price),
                    Description = du.Time
                };
                var sessionId = await CheckOut(info, "http://localhost:3000");
                var pubKey = _configuration["Stripe:PubKey"];



                return Ok(new
                {
                    SessionId = sessionId,
                    PubKey = pubKey
                }); ;
            }
            else
            {
                return StatusCode(500);
            }
        }

        [NonAction]
        public async Task<string> CheckOut(PaymentInfo info, string thisApiUrl)
        {
            // Create a payment flow from the items in the cart.
            // Gets sent to Stripe API.
            var options = new SessionCreateOptions
            {
                // Stripe calls the URLs below when certain checkout events happen such as success and failure.
                SuccessUrl = $"{thisApiUrl}/checkout/success?sessionId=" + "{CHECKOUT_SESSION_ID}", // Customer paid.
                CancelUrl = "http://localhost:3000/" + "failed",  // Checkout cancelled.
                PaymentMethodTypes = new List<string> // Only card available in test mode?
            {
                "card"
            },
                LineItems = new List<SessionLineItemOptions>
            {
                new()
                {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        UnitAmount = info.Price, // Price is in USD cents.
                        Currency = "USD",
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = info.Name,
                            Description = info.Description,
                            /*Images = new List<string> { product.ImageUrl }*/
                        },
                    },
                    Quantity = 1,
                },
            },
                Mode = "payment" // One-time payment. Stripe supports recurring 'subscription' payments.
            };

            var service = new SessionService();
            var session = await service.CreateAsync(options);
            //return info.Price.ToString();
            return session.Id;
        }

        [HttpGet("success")]
        // Automatic query parameter handling from ASP.NET.
        // Example URL: https://localhost:7051/checkout/success?sessionId=si_123123123123
        public ActionResult CheckoutSuccess(string sessionId)
        {
            var sessionService = new SessionService();
            var session = sessionService.Get(sessionId);

            // Here you can save order and customer details to your database.
            var total = session.AmountTotal.Value;
            var customerEmail = session.CustomerDetails.Email;

            return Redirect(s_wasmClientURL + "success");
        }
    }
}
