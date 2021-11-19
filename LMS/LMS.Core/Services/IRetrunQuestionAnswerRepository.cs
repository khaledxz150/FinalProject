using LMS.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Services
{
   public interface IRetrunQuestionAnswerRepository
    {
        public bool InsertExamQuestionAnswer(ExamQuestionAnswer examQuestionAnswer);

        public bool DeleteExamQuestionAnswer(int examId);

        public List<ExamQuestionAnswer> ReturnExamQuestionAnswer(ExamQuestionAnswer examQuestionAnswer);




    }
}
