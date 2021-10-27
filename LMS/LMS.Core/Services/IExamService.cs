using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Services
{
    public interface IExamService
    {
        public List<Exam> ReturnExam(int queryCode);
        public bool InsertExam(Exam exam);
        public bool UpdateExam(Exam exam);
        public bool DeleteExam(int examId);

        public TraineeSectionExam AddTraineeSectionExam(TraineeSectionExam traineeSectionExam);
        public bool DeleteTraineeSectionExam(int traineeSectionExamId);
        public List<TraineeSectionExam> ReturnTraineeSectionExam();
        public List<TraineeSectionExam> UpdateTraineeSectionExam(TraineeSectionExam traineeSectionExam);


        //ExamQuestion
        public List<ExamQuestion> ReturnExamQuestion(int queryCode);
        public bool InsertExamQuestion(ExamQuestion examQuestion);
        public bool UpdateExamQuestion(ExamQuestion examQuestion);
        public bool DeleteExamQuestion(int questionId);


        //ExamOption

        public List<ExamOption> ReturnExamOption(int queryCode);
        public bool InsertExamOption(ExamOption examOption);
        public bool UpdateExamOption(ExamOption examOption);
        public bool DeleteExamOption(int optionId);

    }
}
