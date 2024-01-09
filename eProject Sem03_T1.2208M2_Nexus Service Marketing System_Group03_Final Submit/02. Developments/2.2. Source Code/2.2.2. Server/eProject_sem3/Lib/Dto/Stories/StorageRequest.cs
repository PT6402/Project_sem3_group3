using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Dto.Stories
{
    public class StorageRequest
    {
        public int Product_id { get; set; }
        public int Quantity_product { get; set; }
        public string? Status { get; set; } = null!;
        public int addressStore_id { get; set; }
    }
}
