using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class CourseRefund
    {
        public int CourseRefundsId { get; set; }
        public int? CheckoutId { get; set; }
        public long? ApprovedEmployeeId { get; set; }
        public string RefundsNotes { get; set; }
        public bool? IsApproved { get; set; }
        public bool? IsActive { get; set; }

        public int? CourseId {  get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual Employee ApprovedEmployee { get; set; }
        public virtual RefundReason RefundsReasons { get; set; }
        public virtual Checkout TraineeByCourse { get; set; }
    }
}
