using System;
namespace Lib.Dto.Orders
{
    public class StaffOrder
    {
        public float Total_Price { get; set; }
        public int Numb_Connect { get; set; }

        public string Order_Id { get; set; }
        public string FullName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Status { get; set; }
        public string Address_full { get; set; } = null!;
        public string Phone_code { get; set; } = null!;
        public string Province_code { get; set; } = null!;
        public string District_code { get; set; } = null!;
        public string Ward_code { get; set; } = null!;
        public string Time { get; set; }
        public string Validate { get; set; }
        public string ConnectType { get; set; }
        public DateTime DateCreate { get; set; }

    }
}

