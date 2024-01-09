using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Entities
{
    public class Banner
    {
        [Key]
        public int Id { get; set; }
        public string? Path { get; set; } = null!;
    }
}
