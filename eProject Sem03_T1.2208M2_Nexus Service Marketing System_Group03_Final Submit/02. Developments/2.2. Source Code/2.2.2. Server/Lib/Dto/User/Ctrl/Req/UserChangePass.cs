using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Dto.User.Ctrl.Req
{
    public class UserChangePass
    {
        public int User_Id { get; set; }
        [Required]
        public string Current_pass { get; set; } = null!;
        [Required]
        public string New_pass { get; set; } = null!;
        [Required]
        public string Confirm_pass { get; set; } = null!;
    }
}
