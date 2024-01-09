using System;
namespace Lib.Dto.Package
{
	public class PackageRes
	{
        public int? package_id { get; set; }
        public string namePackage { get; set; } = null!;
        public int connect_type_id { get; set; }
    }
}

