using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Dto.User.Ctrl.Req
{
    public class UserResetPass
    {
        [Required]
        public string Phone { get; set; } = null!;
        [Required]
        public string NewPass { get; set; } = null!;
    }
}
