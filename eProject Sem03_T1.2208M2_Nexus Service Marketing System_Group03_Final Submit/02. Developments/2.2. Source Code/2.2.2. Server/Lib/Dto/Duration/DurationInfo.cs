using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Dto.Duration
{
    public class DurationInfo
    {
        public int? Id { get; set; }
        public string name { get; set; } = null!;
        public string price { get; set; } = null!;
        public string package_name { get; set; } = null!;
    }
}
