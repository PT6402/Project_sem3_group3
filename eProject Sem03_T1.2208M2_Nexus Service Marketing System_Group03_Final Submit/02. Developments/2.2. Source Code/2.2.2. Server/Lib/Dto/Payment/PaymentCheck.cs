using System;
using System.ComponentModel.DataAnnotations;

namespace Lib.Dto.Payment
{
	public class PaymentCheck
	{
        [Required]
        public string Phone { get; set; } = null!;
      
        
        public string TP_Contract_Id { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public List<ServiceDto>? ServiceDtos { get; set; }
    }
}

