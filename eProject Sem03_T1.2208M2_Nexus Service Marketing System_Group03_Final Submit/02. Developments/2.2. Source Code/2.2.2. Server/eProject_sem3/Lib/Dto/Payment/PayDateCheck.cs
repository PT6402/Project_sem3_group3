using System;
namespace Lib.Dto.Payment
{
    public class PayDateCheck
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int User_Id { get; set; }
    }
}