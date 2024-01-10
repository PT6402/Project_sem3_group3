using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Dto.Supplier.Ctrl
{
    public class SupplierDto
    {
        public int? id { get; set; }
        public string brandName { get; set; } = null!;
        public string? phone { get; set; }
        public string? address { get; set; }
    }
}
