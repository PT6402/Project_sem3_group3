using System;
using System.Net.Http.Headers;
using Api.Data_helper;
using Api.Interface.IRepo;
using Lib.Entities;
using Newtonsoft.Json;
using PayPal.Api;

namespace Api.Repository
{
    public class PayPalRepository : IPayPal
    {
        private readonly string _clientId;
        private readonly string _clientSecret;
        private readonly IConfiguration _configuration;

        public PayPalRepository(IConfiguration configuration)
        {
            _clientId = configuration["PayPal:ClientId"];
            _clientSecret = configuration["PayPal:ClientSecret"];
        }
        private APIContext GetApiContext()
        {
            var config = new Dictionary<string, string>
        {
            { "mode", _configuration["PayPal:Mode"] },
            { "clientId", _configuration["PayPal:ClientId"] },
            { "clientSecret", _configuration["PayPal:ClientSecret"] }
        };

            var accessToken = new OAuthTokenCredential(config).GetAccessToken();
            var apiContext = new APIContext(accessToken);
            return apiContext;
        }

        public async Task<PayPal.Api.Payment> CreatePayment(HttpContext httpContext, decimal amount, string currency, string returnUrl, string cancelUrl)
        {
            var apiContext = GetApiContext();
            var baseUri = new Uri(httpContext.Request.Scheme + "://" + httpContext.Request.Host);

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiContext.AccessToken);
                var requestUrl = new Uri(baseUri, "/v1/payments/payment");

                var paymentRequest = new
                {
                    intent = "sale",
                    payer = new { payment_method = "paypal" },
                    transactions = new[]
                    {
                new
                {
                    amount = new
                    {
                        currency = currency,
                        total = amount.ToString("F")
                    },
                    description = "Transaction description",
                    item_list = new
                    {
                        items = new[]
                        {
                            new
                            {
                                name = "Item Name",
                                currency = currency,
                                price = amount.ToString("F"),
                                quantity = "1"
                            }
                        }
                    }
                }
            },
                    redirect_urls = new
                    {
                        cancel_url = cancelUrl,
                        return_url = returnUrl
                    }
                };

                var response = await httpClient.PostAsJsonAsync(requestUrl, paymentRequest);
                response.EnsureSuccessStatusCode();

                // Read the response content as a string
                var responseContent = await response.Content.ReadAsStringAsync();

                // Deserialize the JSON string into a Payment object
                var createdPayment = JsonConvert.DeserializeObject<PayPal.Api.Payment>(responseContent);

                return createdPayment;
            }
        }





        public async Task<PayPal.Api.Payment> ExecutePayment(HttpContext httpContext, string payerId, string paymentId)
        {
            var apiContext = GetApiContext();
            var baseUri = new Uri(httpContext.Request.Scheme + "://" + httpContext.Request.Host);

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiContext.AccessToken);
                var requestUrl = new Uri(baseUri, $"/v1/payments/payment/{paymentId}/execute");

                var paymentExecution = new
                {
                    payer_id = payerId
                };

                var response = await httpClient.PostAsJsonAsync(requestUrl, paymentExecution);
                response.EnsureSuccessStatusCode();

                // Read the response content as a string
                var responseContent = await response.Content.ReadAsStringAsync();

                // Deserialize the JSON string into a Payment object
                var executedPayment = JsonConvert.DeserializeObject<PayPal.Api.Payment>(responseContent);

                return executedPayment;
            }
        }


    }
}

