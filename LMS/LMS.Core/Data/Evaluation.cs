using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class Evaluation
    {
        public Evaluation()
        {
            EvaluationFormsAnswers = new HashSet<EvaluationFormsAnswer>();
            EvaluationFormsQuestions = new HashSet<EvaluationFormsQuestion>();
        }

        public int EvaluationId { get; set; }
        public int? SectionId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }

        public virtual Employee CreatedByNavigation { get; set; }
        public virtual Section Section { get; set; }
        public virtual ICollection<EvaluationFormsAnswer> EvaluationFormsAnswers { get; set; }
        public virtual ICollection<EvaluationFormsQuestion> EvaluationFormsQuestions { get; set; }
    }
}
