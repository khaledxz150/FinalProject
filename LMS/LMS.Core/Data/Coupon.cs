using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class Coupon
    {
        public Coupon()
        {
            TraineeBuyCourses = new HashSet<Checkout>();
        }

        public int CouponId { get; set; }
        public string Code { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? Redemption { get; set; }
        public decimal? Discount { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public long CreatedBy { get; set; }
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Employee CreatedByNavigation { get; set; }
        public virtual ICollection<Checkout> TraineeBuyCourses { get; set; }
    }
}
