using System;
using System.ComponentModel.DataAnnotations;

namespace Lib.Dto.FeedbackSend
{
	public class SendDto
	{
        [Required]
        public int User_Id { get; set; }
        [Required]
        public int Duration_Id { get; set; }
        public int Address_Store_Id { get; set; }
        [StringLength(100)]
        public string Content { get; set; }
        
    }
}

