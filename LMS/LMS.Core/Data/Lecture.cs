using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class Lecture
    {
        public int LectureId { get; set; }
        public int SectionId { get; set; }
        public TimeSpan StartAt { get; set; }
        public TimeSpan EndAt { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public long CreatedBy { get; set; }

        public virtual Employee CreatedByNavigation { get; set; }
        public virtual Section Section { get; set; }
    }
}
