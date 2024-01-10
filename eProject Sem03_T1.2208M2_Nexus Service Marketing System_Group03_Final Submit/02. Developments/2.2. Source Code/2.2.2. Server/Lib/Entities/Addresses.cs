using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Entities
{
    [Table("tbAddress")]
    public class Addresses
    {
        [Key]
        public int Id { get; set; }
        public string Address_full { get; set; } = null!;
        public string Phone_code { get; set; } = null!;
        public string Province_code { get; set; } = null!;
        public string District_code { get; set; } = null!;
        public string Ward_code { get; set; } = null!;

        public Order? Order { get; set; }
        public Address_store? Address_Store { get; set; }

    }
}
