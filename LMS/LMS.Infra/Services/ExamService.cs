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

      
        public List<TraineeSectionExam> AddTraineeSectionExam(TraineeSectionExam traineeSectionExam)
        {
            return examRepository.AddTraineeSectionExam(traineeSectionExam);
        }

    
        public bool DeleteTraineeSectionExam(int traineeSectionExamId)
        {
            return examRepository.DeleteTraineeSectionExam(traineeSectionExamId);
        }


        public List<TraineeSectionExam> ReturnTraineeSectionExam() {

            return examRepository.ReturnTraineeSectionExam();


        }

        public List<TraineeSectionExam> UpdateTraineeSectionExam(TraineeSectionExam traineeSectionExam)
        {
            return examRepository.UpdateTraineeSectionExam(traineeSectionExam);
        }

        //ExamQuestion

        public bool DeleteExamQuestion(int questionId)
        {
            return examRepository.DeleteExamQuestion(questionId);
        }

        public bool InsertExamQuestion(ExamQuestion examQuestion)
        {
            return examRepository.InsertExamQuestion(examQuestion);
        }

        public List<ExamQuestion> ReturnExamQuestion(int queryCode)
        {
            return examRepository.ReturnExamQuestion(queryCode);
        }

        public bool UpdateExamQuestion(ExamQuestion examQuestion)
        {
            return examRepository.UpdateExamQuestion(examQuestion);
        }

        //ExamOption


        public bool DeleteExamOption(int optionId)
        {
            return examRepository.DeleteExamOption(optionId);
        }

        public bool InsertExamOption(ExamOption examOption)
        {
            return examRepository.InsertExamOption(examOption);
        }

        public List<ExamOption> ReturnExamOption(int queryCode)
        {
            return examRepository.ReturnExamOption(queryCode);
        }

        public bool UpdateExamOption(ExamOption examOption)
        {
            return examRepository.UpdateExamOption(examOption);
        }
    }
}
