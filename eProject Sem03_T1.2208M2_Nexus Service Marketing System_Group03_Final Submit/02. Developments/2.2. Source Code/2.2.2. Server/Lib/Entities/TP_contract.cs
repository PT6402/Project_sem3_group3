using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lib.Entities
{
    [Table("tbTP_contract")]
    public class TP_contract
    {
        [Key]
        public string Id { get; set; } = null!;

        [Required]
        public int User_Id { get; set; }
        public User? User { get; set; }


        public ICollection<Contract_Service>? Contract_Services { get; set; }
    }
}
