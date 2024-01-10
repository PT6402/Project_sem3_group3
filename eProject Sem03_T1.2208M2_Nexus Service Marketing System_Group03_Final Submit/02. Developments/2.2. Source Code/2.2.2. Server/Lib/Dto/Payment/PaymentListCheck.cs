using System;
namespace Lib.Dto.Payment
{
	public class PaymentListCheck
	{
        public DateTime NextPay { get; set; }
        public string Contract_Service_Id { set; get; }
        public float Last_payment_value { get; set; }
    }
}

