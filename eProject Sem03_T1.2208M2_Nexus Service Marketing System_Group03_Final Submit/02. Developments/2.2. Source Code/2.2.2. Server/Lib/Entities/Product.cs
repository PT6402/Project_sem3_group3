using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lib.Entities
{
    [Table("tbProduct")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Numb_Connect { get; set; }

        [Required]
        public int Connect_type_Id { get; set; }
        public Connect_type? Connect_type { get; set; }

        [Required]
        public int Supplier_Id { get; set; }
        public Supplier Supplier { get; set; } = null!;

        public ICollection<ImportReceipt>? ImportReceipt { get; set; }
    }
}
