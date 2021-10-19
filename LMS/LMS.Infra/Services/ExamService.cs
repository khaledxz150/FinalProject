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
    public class ExamService : IExamService
    {
        private readonly IExamRepository examRepository;

        public ExamService(IExamRepository examRepository)
        {
            this.examRepository = examRepository;
        }
        public bool DeleteExam(int examId)
        {
            return examRepository.DeleteExam(examId);
        }

        public bool InsertExam(Exam exam)
        {
            return examRepository.InsertExam(exam);
        }

        public List<Exam> ReturnExam(int queryCode)
        {
            return examRepository.ReturnExam(queryCode);
        }

        public bool UpdateExam(Exam exam)
        {
            return examRepository.UpdateExam(exam);
        }
    }
}
