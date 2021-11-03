using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.DTO
{
    public class ExamAnswersDTO
    {
        public int ExamId { get; set; }
        public int QuestionId { get; set; }
        public String QuestionText { get; set; }
        public String QuestionImage { get; set; }

        public int AnswerId {  get; set; }
        public String AnswerText {  get; set; }
        public String TraineeName { get; set; }
    
    }

}
