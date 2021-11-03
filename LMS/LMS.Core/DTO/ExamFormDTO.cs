using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.DTO
{
    public class ExamFormDTO
    {
        public int ExamId {  get; set; }
        public int QuestionId { get; set; }
        public String QuestionText { get; set; }
        public String QuestionImage { get; set; }
    }
}
