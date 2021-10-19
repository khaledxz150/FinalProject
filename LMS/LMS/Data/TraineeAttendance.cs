using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class TraineeAttendance
    {
        public int TraineeAttendanceId { get; set; }
        public int TraineeSectionId { get; set; }
        public bool Status { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public long CreatedBy { get; set; }

        public virtual Employee CreatedByNavigation { get; set; }
        public virtual TraineeSection TraineeSection { get; set; }
    }
}
