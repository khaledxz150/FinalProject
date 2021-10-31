using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class EvalouationQusetion
    {

        public int EvalouationQusetionId { get; set; }
        public string Descrition { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public long CreatedBy { get; set; }

        public virtual Employee CreatedByNavigation { get; set; }
        public virtual ICollection<EvalouationAnswer> EvalouationAnswers { get; set; }
        public virtual ICollection<EvaluationFormsQuestion> EvaluationFormsQuestions { get; set; }
    }
}
