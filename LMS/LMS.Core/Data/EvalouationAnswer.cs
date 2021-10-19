using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class EvalouationAnswer
    {
        public EvalouationAnswer()
        {
            EvaluationFormsAnswers = new HashSet<EvaluationFormsAnswer>();
        }

        public int EvalouationAnswerId { get; set; }
        public string Description { get; set; }
        public int? EvalouationQuestionId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }

        public virtual Employee CreatedByNavigation { get; set; }
        public virtual EvalouationQusetion EvalouationQuestion { get; set; }
        public virtual ICollection<EvaluationFormsAnswer> EvaluationFormsAnswers { get; set; }
    }
}
