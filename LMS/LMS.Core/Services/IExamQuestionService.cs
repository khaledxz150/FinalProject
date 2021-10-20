using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Services
{
    public interface IExamQuestionService
    {
        public List<ExamQuestion> ReturnExamQuestion(int queryCode);
        public bool InsertExamQuestion(ExamQuestion examQuestion);
        public bool UpdateExamQuestion(ExamQuestion examQuestion);
        public bool DeleteExamQuestion(int questionId);
    }
}
