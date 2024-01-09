using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lib.Entities
{
    [Table("tbDuration")]
    public class Duration
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Package_Id { get; set; }
        public Package? Package { get; set; }
        public string? Time { get; set; }
        public float Price { get; set; }
        public string? Validate { get; set; }
        public string? Description { get; set; }

        public ICollection<Call_charges>? Call_Charges { get; set; }

        public ICollection<Duration_callCharges>? Duration_callChargeses { get; set; }
        public ICollection<Order>? Orders { get; set; }
        public ICollection<Feedback>? Feedbacks { get; set; }

    }
}
