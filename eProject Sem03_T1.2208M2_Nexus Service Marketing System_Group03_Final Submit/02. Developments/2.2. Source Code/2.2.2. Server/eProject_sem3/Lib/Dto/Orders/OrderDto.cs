using System;
namespace Lib.Dto.Orders
{
	public class OrderDto
	{
        public string? Id { get; set; }
        public string? Status { get; set; } 
        public string? Tax { get; set; } 
        public float Total_Price { get; set; }
        public int Numb_Connect { get; set; }
        public int? Coupon_Id { get; set; }
        public int? Duration_callCharges_Id { get; set; }
        public string? ContractService_Id { get; set; } 
        public int Duration_Id { get; set; }
        public int User_Id { get; set; }
        public int Addresses_Id { get; set; }
        public int Address_store_Id { get; set; }
        //address
        public string Address_full { get; set; } = null!;
        public string Phone_code { get; set; } = null!;
        public string Province_code { get; set; } = null!;
        public string District_code { get; set; } = null!;
        public string Ward_code { get; set; } = null!;
    }
}

