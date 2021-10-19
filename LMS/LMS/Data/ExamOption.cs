using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class ExamOption
    {
        public int OptionId { get; set; }
        public string Description { get; set; }
        public bool IsCorrect { get; set; }
        public int QuestionId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public long CreatedBy { get; set; }

        public virtual Employee CreatedByNavigation { get; set; }
        public virtual ExamQuestion Question { get; set; }
    }
}
