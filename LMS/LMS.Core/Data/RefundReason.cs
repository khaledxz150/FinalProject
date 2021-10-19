using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class RefundReason
    {
        public RefundReason()
        {
            CourseRefunds = new HashSet<CourseRefund>();
        }

        public int ReasonId { get; set; }
        public string ReasonDescription { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual ICollection<CourseRefund> CourseRefunds { get; set; }
    }
}
