using System;
using System.ComponentModel.DataAnnotations;

namespace Lib.Entities
{
	public class Feedback
	{
        [Key]
        public int Id { get; set; }
        [Required]
        public int User_Id { get; set; }
        public User User { get; set; }
        [Required]
        public int Duration_Id { get; set; }
        public Duration Duration { get; set; }
        public int Address_Store_Id { get; set; }
        [StringLength(100)]
        public string Content { get; set; }
        [StringLength(100)]
        public string? Reply { get; set; }
    }
}

