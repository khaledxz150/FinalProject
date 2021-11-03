using LMS.Core.Data;
using LMS.Core.DTO;
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


        public bool AddTraineeSectionExam(TraineeSectionExam traineeSectionExam)
        {
            return examRepository.AddTraineeSectionExam(traineeSectionExam);
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

        public List<ExamQuestion> ReturnExamQuestion(int queryCode, int courseId)
        {
            return examRepository.ReturnExamQuestion(queryCode, courseId);
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

        public List<ExamOption> ReturnExamOption(int queryCode, int questionId)
        {
            return examRepository.ReturnExamOption(queryCode, questionId);
        }

        public bool UpdateExamOption(ExamOption examOption)
        {
            return examRepository.UpdateExamOption(examOption);
        }

        public List<Exam> ReturnExamBySectionId(int sectionId)
        {
            return examRepository.ReturnExamBySectionId(sectionId);
        }

        //Section Exam 
        public bool InsertSectionExam(SectionExam sectionExam)
        {
            return examRepository.InsertSectionExam(sectionExam);
        }
        //SectionExamAnswer
        public bool InsertSectionExamAnswer(SectionExamAnswer sectionExamAnswer)
        {
            return examRepository.InsertSectionExamAnswer(sectionExamAnswer);
        }
        // <---------------------- DTO --------------------------------> 
        public List<GetTraineeMarksDTO> GetTraineeMarks(int sectionId)
        {
            return examRepository.GetTraineeMarks(sectionId);
        }
        public List<TraineeAnswersDTO> GetTraineeAnswer(int sectionId) {
            return examRepository.GetTraineeAnswer(sectionId);     
        }

        public List<ExamFormDTO> GetExamForm(int sectionId) {
            return examRepository.GetExamForm(sectionId);
        }

        public List<ExamAnswersDTO> GetExamAnswersDTOs(int sectionId) {
            return examRepository.GetExamAnswersDTOs(sectionId);
        }
    }
}
