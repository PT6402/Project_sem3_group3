using System;
namespace Lib.Dto.Orders
{
    public class OrderRes
    {
        public string Id { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string Tax { get; set; } = null!;
        public float Total_Price { get; set; }
        public int Numb_Connect { get; set; }
        public int? Coupon_Id { get; set; }
        public bool StatusFeedback { get; set; }
        public string? FeedbackContent { set; get; }

        public string? ContractService_Id { get; set; } = null;
        public int Duration_Id { get; set; }
        public int User_Id { get; set; }
        public int Addresses_Id { get; set; }
    }
}