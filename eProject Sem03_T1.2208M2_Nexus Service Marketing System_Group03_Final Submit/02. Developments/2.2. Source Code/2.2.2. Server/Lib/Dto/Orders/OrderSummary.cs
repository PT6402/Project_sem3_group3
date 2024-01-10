using System;
namespace Lib.Dto.Orders
{
    public class OrderSummary
    {
        public string OrderId { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public string FullName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string ConnectTypeName { get; set; } = null!;
        public string PackageName { get; set; } = null!;
        public string? DurationTime { get; set; }
        public string? Validate { get; set; }
        public float PackagePrice { get; set; }
        public float Deposit { get; set; }
        public float Coupon { get; set; }
        public string Tax { get; set; } = null!;
        public float TotalPrice { get; set; }
        public string Status { get; set; }
        public int duration_Id { get; set; }
        public int address_Store_Id { get; set; }
        public bool StatusFeedback { get; set; }
        public string? FeedbackContent { set; get; }
    }
}