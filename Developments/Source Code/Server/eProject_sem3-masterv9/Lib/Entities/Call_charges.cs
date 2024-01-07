using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lib.Entities
{
    [Table("tbCall_charges")]
    public class Call_charges
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public float Price { get; set; }
        public string Unit { get; set; } = null!;

        [Required]
        public int Duration_Id { get; set; }
        public Duration? Duration { get; set; }

        public ICollection<Duration_callCharges>? Duration_CallCharges { get; set; }

    }
}
