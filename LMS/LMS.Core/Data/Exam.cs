using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class Exam
    {
        public int ExamId { get; set; }
        public int SectionId { get; set; }
        public DateTime ExamDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public long CreatedBy { get; set; }
        public int Mark { get; set;  }

        public int Weight {  get; set; }

        public virtual Employee CreatedByNavigation { get; set; }
        public virtual Section Section { get; set; }
    }
}
