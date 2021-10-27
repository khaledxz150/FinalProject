using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class Testimonial
    {
        public int TestimonialsId { get; set; }
        public string Description { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public bool? IsApproved { get; set; }
        public long? ApprovedEmployeeId { get; set; }

        public virtual Employee ApprovedEmployee { get; set; }
        public virtual Employee CreatedByNavigation { get; set; }
    }
}
