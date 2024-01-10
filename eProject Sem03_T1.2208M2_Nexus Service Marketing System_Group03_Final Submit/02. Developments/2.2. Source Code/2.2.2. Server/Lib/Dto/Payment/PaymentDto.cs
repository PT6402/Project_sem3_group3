using System;
namespace Lib.Dto.Payment
{
	public class PaymentDto
	{
        public int? Id { get; set; }
        public string Order_Id { get; set; } = null!;
        public string Method_Payment { get; set; } = null!;
        public bool Status { get; set; }
    }
}

