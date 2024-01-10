using System;
namespace Lib.Dto.User.Repo
{
    public class UpdateProfile
    {
        public int User_Id { get; set; }
        public string? Fullname { get; set; }
        public string? Email { get; set; }
    }
}