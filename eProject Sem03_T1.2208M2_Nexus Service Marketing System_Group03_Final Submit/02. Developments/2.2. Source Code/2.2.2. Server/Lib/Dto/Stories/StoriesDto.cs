using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Dto.Stories
{
    public class StoriesDto
    {
        public int? Id { get; set; }
        public int Product_id { get; set; }
        public int Quantity_product { get; set; }
        public DateTime Time { get; set; }
        public string? Status { get; set; } = null!;
        public int Storage_id { get; set; }
    }
}
