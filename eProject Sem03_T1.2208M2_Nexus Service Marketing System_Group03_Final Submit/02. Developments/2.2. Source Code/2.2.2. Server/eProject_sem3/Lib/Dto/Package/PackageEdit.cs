using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Dto.Package
{
    public class PackageEdit
    {
        public int? package_id { get; set; }
        public string namePackage { get; set; } = null!;
    }
}
