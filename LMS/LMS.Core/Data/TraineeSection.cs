using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class TraineeSection
    {


        public int TraineeSectionId { get; set; }
        public int TraineeId { get; set; }
        public int SectionId { get; set; }
        public decimal? TotalMark { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public long? CreatedBy { get; set; }

        public virtual Employee CreatedByNavigation { get; set; }
        public virtual Section Section { get; set; }
        public virtual Trainee Trainee { get; set; }
        public virtual ICollection<TraineeAttendance> TraineeAttendances { get; set; }
        public virtual ICollection<TraineeSectionExam> TraineeSectionExams { get; set; }
        public virtual ICollection<TraineeSectionTask> TraineeSectionTasks { get; set; }
    }
}
