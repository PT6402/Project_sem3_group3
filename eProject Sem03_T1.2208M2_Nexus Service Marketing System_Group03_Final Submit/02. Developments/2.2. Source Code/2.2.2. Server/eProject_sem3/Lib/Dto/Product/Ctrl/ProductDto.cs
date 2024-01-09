using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Dto.Product.Ctrl
{
    public class ProductDto
    {
        public int? id { get; set; }
        public string name { get; set; } = null!;
        public int numb_connect { get; set; }
        public int connect_type_id { get; set; }
        public int supplier_id { get; set; }
    }
}
