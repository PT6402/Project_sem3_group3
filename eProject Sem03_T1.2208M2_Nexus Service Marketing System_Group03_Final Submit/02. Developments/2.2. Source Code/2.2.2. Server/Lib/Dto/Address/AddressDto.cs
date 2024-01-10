using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Dto.Address
{
    public class AddressDto
    {
        public int? Id { get; set; }
        public string Address_full { get; set; } = null!;
        public string Phone_code { get; set; } = null!;
        public string Province_code { get; set; } = null!;
        public string District_code { get; set; } = null!;
        public string Ward_code { get; set; } = null!;
    }
}
