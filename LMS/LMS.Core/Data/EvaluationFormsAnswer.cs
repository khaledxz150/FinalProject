using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class EvaluationFormsAnswer
    {
        public int EvaluationFormsAnswersId { get; set; }
        public int? EvaluationId { get; set; }
        public int? EvaluationAnswerId { get; set; }
        public int? TraineeId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual Evaluation Evaluation { get; set; }
        public virtual EvalouationAnswer EvaluationAnswer { get; set; }
        public virtual Trainee Trainee { get; set; }
    }
}
