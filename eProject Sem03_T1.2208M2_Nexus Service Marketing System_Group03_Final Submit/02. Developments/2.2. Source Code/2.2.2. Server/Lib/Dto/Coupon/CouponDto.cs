using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Dto.Coupon
{
    public class CouponDto
    {
        public int? id { get; set; }
        public string name { get; set; }
        public int to { get; set; }
        public int from { get; set; }
        public float percent_discount { get; set; }
    }
}
