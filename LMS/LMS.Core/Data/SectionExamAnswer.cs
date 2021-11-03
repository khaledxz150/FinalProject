using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Data
{
    public partial class SectionExamAnswer
    {
        public int SectionExamAnswerId {  get; set; }
        public int SectionExamId { get; set; }
        public int OptionId { get; set; }
        public int TraineeId { get; set; }

        public virtual ICollection<SectionExam> SectionExams { get; set; }
        public virtual ICollection<ExamOption> ExamOptions { get; set; }
        public virtual ICollection<Trainee> Trainees { get; set; }
    }
}
