using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lib.Entities
{
    [Table("tbOrders")]
    public class Order
    {
        [Key]
        public string Id { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string Tax { get; set; } = null!;
        public float Total_Price { get; set; }
        public int Numb_Connect { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int? Coupon_Id { get; set; }
        public Coupon? Coupon { get; set; }


        public string? ContractService_Id { get; set; } = null;
        public Contract_Service? Contract_Service { get; set; }

        public ICollection<Order_handler>? Order_handlers { get; set; }

        public int? Duration_callCharges_Id { get; set; }
        public Duration_callCharges? Duration_callCharges { get; set; }

        [Required]
        public int Duration_Id { get; set; }
        public Duration? Duration { get; set; }

        [Required]
        public int User_Id { get; set; }
        public User? User { get; set; }

        [Required]
        public int Addresses_Id { get; set; }
        public Addresses? Addresses { get; set; }

        public ICollection<Payment>? Payments { get; set; }
    }
}
