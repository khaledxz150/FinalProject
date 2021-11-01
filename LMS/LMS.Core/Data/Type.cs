using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class Type
    {

        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public bool IsActive { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual Employee CreatedByNavigation { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
