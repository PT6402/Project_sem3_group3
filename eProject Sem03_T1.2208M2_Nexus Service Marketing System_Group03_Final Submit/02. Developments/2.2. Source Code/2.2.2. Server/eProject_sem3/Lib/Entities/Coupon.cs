using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lib.Entities
{
    [Table("tbCoupon")]
    public class Coupon
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int To { get; set; }
        public int From { get; set; }
        public float Percent_discount { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }
}
