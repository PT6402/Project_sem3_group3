using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lib.Entities
{

    [Table("tbImportReceipt")]
    public class ImportReceipt
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Product_Id { get; set; }
        public Product? Product { get; set; }
        public int Quantity { get; set; }
        public DateTime Time { get; set; }
        public string Status { get; set; } = null!;

        [Required]
        public int Storage_id { get; set; }
        public Storage? Storage { get; set; }
    }
}
