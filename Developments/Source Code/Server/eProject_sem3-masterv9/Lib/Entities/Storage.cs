using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Entities
{
    [Table("tbStorage")]
    public class Storage
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Address_store_id { get; set; }
        public Address_store? Address_Store { get; set; }   
        public ICollection<ImportReceipt>? import_receipt { get; set; }
    }
}
