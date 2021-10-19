using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class TraineeBuyCourse
    {
        public TraineeBuyCourse()
        {
            CourseRefunds = new HashSet<CourseRefund>();
        }

        public int TraineeBuyCourseId { get; set; }
        public int CourseId { get; set; }
        public int TraineeId { get; set; }
        public int? CouponId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual Coupon Coupon { get; set; }
        public virtual Course Course { get; set; }
        public virtual Trainee Trainee { get; set; }
        public virtual ICollection<CourseRefund> CourseRefunds { get; set; }
    }
}
