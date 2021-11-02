using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class Tag
    {

        public int TagId { get; set; }
        public string TagName { get; set; }
       
        public long CreatedBy { get; set; }

        public virtual Employee CreatedByNavigation { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
