using System;
namespace Lib.Dto.User.Repo
{
	public class UserShow
	{
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string? Status { get; set; }
    }
}

