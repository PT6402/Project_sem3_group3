using System;
using System.ComponentModel.DataAnnotations;

namespace Lib.Dto.FeedbackSend
{
	public class ReplyDto
	{
        [Required]
        public int Feedback_Id { get; set; }
        [StringLength(100)]
        public string? Reply { get; set; }
    }
}

