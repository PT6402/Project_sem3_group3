using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Dto.User.Ctrl.Req
{
    public class UserCheckAccount
    {
        [Required]
        public string AccountPhone { get; set; } = null!;
        [Required]
        public string Type { get; set; } = null!;

    }
}
