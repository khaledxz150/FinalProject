using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LMS.Core.Data
{
    public partial class SectionExam
    {
        public int SectionExamId {  get; set; }
        public int ExamQuestionId { get; set; } 
        public int ExamId { get; set; }

       
        public virtual ICollection<ExamQuestion> ExamOptions { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
    }
}
