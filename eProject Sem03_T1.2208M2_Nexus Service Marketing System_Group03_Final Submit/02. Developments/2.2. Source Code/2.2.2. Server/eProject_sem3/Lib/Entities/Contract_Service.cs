using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Entities
{
    [Table("tbContract_Service")]
    public class Contract_Service
    {
        [Key]
        public string Id { get; set; } = null!;

        //[ORDER]
        [Required]
        public string Order_Id { get; set; } = null!;
        public Order? Order { get; set; }

        //[TP_CONTRACT]
        [Required]
        public string TP_Contract_Id { get; set; } = null!;
        public TP_contract? TP_Contract { get; set; }

        //[ID_CONTRACT]
        public string? ContractCode { get; set; }
    }
}
