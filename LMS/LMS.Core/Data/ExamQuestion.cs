using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class ExamQuestion
    {
        public ExamQuestion()
        {
            ExamOptions = new HashSet<ExamOption>();
        }

        public int QuestionId { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
        public int CourseId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public long CreatedBy { get; set; }

        public virtual Course Course { get; set; }
        public virtual Employee CreatedByNavigation { get; set; }
        public virtual ICollection<ExamOption> ExamOptions { get; set; }
    }
}
