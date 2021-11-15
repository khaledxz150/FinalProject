using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.DTO
{
    public class CouponDTO
    {
        public int CouponId { get; set; }
        public int CourseId { get; set; }
        public string Code { get; set; }
        public decimal? Discount { get; set; }
        public int? Redemption { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string CourseName { get; set; }
        public decimal CoursePrice { get; set; }
        public decimal CurrentPrice { get; set; }
        public string CourseImage { get; set; }
        public bool IsActive { get; set; }
    }
}
