using System;
namespace Lib.Dto.Address
{
	public class AddressStoreDto
	{
        public string Address_full { get; set; } = null!;
        public string Phone_code { get; set; } = null!;
        public string Province_code { get; set; } = null!;
        public string District_code { get; set; } = null!;
        public string Ward_code { get; set; } = null!;
     
    }
}

