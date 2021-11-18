using LMS.Core.Data;
using LMS.Core.DTO;
using LMS.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Repository
{
    public interface IExamRepository
    {



        public List<Exam> ReturnExam(int queryCode);
        public bool InsertExam(Exam exam);
        public bool UpdateExam(Exam exam);
        public bool DeleteExam(int examId);

        //Trainee Section Exam
        public bool AddTraineeSectionExam(TraineeSectionExam traineeSectionExam);
       
        //insert

         public bool InsertExamAnswerQuestion()


        //ExamQuestion
        public List<ExamQuestion> ReturnExamQuestion(int queryCode, int courseId);
        public bool InsertExamQuestion(ExamQuestion examQuestion);
        public bool UpdateExamQuestion(ExamQuestion examQuestion);
        public bool DeleteExamQuestion(int questionId);


        //ExamOption

        public List<ExamOption> ReturnExamOption(int queryCode, int questionId);
        public bool InsertExamOption(ExamOption examOption);
        public bool UpdateExamOption(ExamOption examOption);
        public bool DeleteExamOption(int optionId);

        //ReturnExamBySectionId
        public List<Exam> ReturnExamBySectionId(int sectionId);

        //Section Exam 
        public bool InsertSectionExam(SectionExam sectionExam);

        //SectionExamAnswer
        public bool InsertSectionExamAnswer(SectionExamAnswer sectionExamAnswer);

        // <---------------------- DTO --------------------------------> 
        public List<GetTraineeMarksDTO> GetTraineeMarks(int sectionId);
        public List<TraineeAnswersDTO> GetTraineeAnswer(int sectionId);

        public List<ExamFormDTO>GetExamForm(int sectionId);

        public List<ExamAnswersDTO>GetExamAnswersDTOs(int sectionId);
        


    }
}
