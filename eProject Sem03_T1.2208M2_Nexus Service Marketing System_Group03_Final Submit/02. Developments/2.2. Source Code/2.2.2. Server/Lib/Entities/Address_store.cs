using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Lib.Entities
{
    [Table("tbAddress_store")]
    public class Address_store
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Address_Id { get; set; }
        public Addresses? Addresses { get; set; }

        public Storage? Storage { get; set; }

        public ICollection<Employee>? Employees { get; set; }
        public ICollection<Order_handler>? Order_handlers { get; set; }
    }
}
