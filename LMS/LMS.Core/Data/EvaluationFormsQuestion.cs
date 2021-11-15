using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class EvaluationFormsQuestion
    {
        public int EvaluationFormsQuestionId { get; set; }
        public int? EvaluationId { get; set; }
        public int? QuestionId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public long CreatedBy { get; set; }

        public virtual Employee CreatedByNavigation { get; set; }
        public virtual Evaluation Evaluation { get; set; }
        public virtual EvalouationQusetion Question { get; set; }
    }
}
