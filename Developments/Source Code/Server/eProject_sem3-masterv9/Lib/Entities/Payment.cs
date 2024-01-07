using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lib.Entities
{
    [Table("tbPayment")]
    public class Payment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Order_Id { get; set; } = null!;
        public Order? Order { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;

        public string Method_Payment { get; set; } = null!;
        public bool Status { get; set; }
    }
}
