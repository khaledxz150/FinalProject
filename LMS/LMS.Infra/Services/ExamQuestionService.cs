using LMS.Core.Repository;
using LMS.Core.Services;
using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infra.Services
{
    public class ExamQuestionService: IExamQuestionService
    {
        private readonly IExamQuestionRepository examQuestionRepository;

        public ExamQuestionService(IExamQuestionRepository examQuestionRepository)
        {
            this.examQuestionRepository = examQuestionRepository;
        }

        public bool DeleteExamQuestion(int questionId)
        {
            return examQuestionRepository.DeleteExamQuestion(questionId);
        }

        public bool InsertExamQuestion(ExamQuestion examQuestion)
        {
            return examQuestionRepository.InsertExamQuestion(examQuestion);
        }

        public List<ExamQuestion> ReturnExamQuestion(int queryCode)
        {
            return examQuestionRepository.ReturnExamQuestion(queryCode);
        }

        public bool UpdateExamQuestion(ExamQuestion examQuestion)
        {
            return examQuestionRepository.UpdateExamQuestion(examQuestion);
        }
    }
}
