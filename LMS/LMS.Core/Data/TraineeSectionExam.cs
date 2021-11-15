using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class TraineeSectionExam
    {
        public int TraineeSectionExamId { get; set; }
       
        public int ExamId { get; set; }
        public decimal? Mark { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public int  TraineeId { get; set;  }
        public long CreatedBy { get; set; }
        public virtual Employee CreatedByNavigation { get; set; }
        public virtual Trainee Trainee { get; set; }
    }
}
