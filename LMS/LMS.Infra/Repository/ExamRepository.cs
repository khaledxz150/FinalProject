using Dapper;
using First.Core.Common;
using LMS.Core.Data;
using LMS.Core.DTO;
using LMS.Core.Repository;
using LMS.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infra.Repository
{
    public class ExamRepository : IExamRepository
    {
        private IDbContext dBContext;
        public ExamRepository(IDbContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public bool DeleteExam(int examId)
        {
            var parm = new DynamicParameters();
            parm.Add("@ExamId", examId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("DeleteExam", parm, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool InsertExam(Exam exam)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@SectionId", exam.SectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@ExamDate", exam.ExamDate, dbType: DbType.Date, direction: ParameterDirection.Input);
            parameters.Add("@StartTime", exam.StartTime, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            parameters.Add("@EndTime", exam.EndTime, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            parameters.Add("@CreatedBy", exam.CreatedBy, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Mark", exam.Mark, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Weight", exam.Weight, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("InsertExam", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Exam> ReturnExam(int queryCode)
        {
            var parm = new DynamicParameters();
            parm.Add("@P_CODE", queryCode, dbType: DbType.Int32, direction: ParameterDirection.Input);
           
            IEnumerable<Exam> result = dBContext.Connection.Query<Exam>("ReturnExam", parm, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateExam(Exam exam)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@ExamId", exam.ExamId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@ExamDate", exam.ExamDate, dbType: DbType.Date, direction: ParameterDirection.Input);
            parameters.Add("@StartTime", exam.StartTime, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            parameters.Add("@EndTime", exam.EndTime, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            parameters.Add("@Mark", exam.Weight, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Weight", exam.Mark, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("UpdateExam", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool AddTraineeSectionExam(TraineeSectionExam traineeSectionExam)
        {
            var parm = new DynamicParameters();
           
            parm.Add("@P_ExamId", traineeSectionExam.ExamId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_Mark", traineeSectionExam.Mark, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            parm.Add("@P_TraineeId", traineeSectionExam.TraineeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@CreatedBy", traineeSectionExam.CreatedBy, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("InsertTraineeSectionExam", parm, commandType: CommandType.StoredProcedure);
            return true;
        }



        //ExamQuestion

        public bool DeleteExamQuestion(int questionId)
        {
            var parm = new DynamicParameters();
            parm.Add("@QuestionId", questionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("DeleteExamQuestion", parm, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool InsertExamQuestion(ExamQuestion examQuestion)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Description", examQuestion.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@ImageName", examQuestion.ImageName, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@CourseId", examQuestion.CourseId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@CreatedBy", examQuestion.CreatedBy, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("InsertExamQuestion", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<ExamQuestion> ReturnExamQuestion(int queryCode, int courseId)
        {
            var parm = new DynamicParameters();
            parm.Add("@P_CODE", queryCode, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<ExamQuestion> result = dBContext.Connection.Query<ExamQuestion>("ReturnExamQuestion", parm, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateExamQuestion(ExamQuestion examQuestion)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@QuestionId", examQuestion.QuestionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Description", examQuestion.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@ImageName", examQuestion.ImageName, dbType: DbType.String, direction: ParameterDirection.Input);
          
            parameters.Add("@IsActive", examQuestion.IsActive, dbType: DbType.Boolean, direction: ParameterDirection.Input);


            var result = dBContext.Connection.ExecuteAsync("UpdateExamQuestion", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }


        //ExamOption

        public bool DeleteExamOption(int optionId)
        {
            var parm = new DynamicParameters();
            parm.Add("@OptionId", optionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("DeleteExamOption", parm, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool InsertExamOption(ExamOption examOption)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Description", examOption.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@IsCorrect", examOption.IsCorrect, dbType: DbType.Boolean, direction: ParameterDirection.Input);
            parameters.Add("@QuestionId", examOption.QuestionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@CreatedBy", examOption.CreatedBy, dbType: DbType.Int64, direction: ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("InsertExamOption", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<ExamOption> ReturnExamOption(int queryCode,int questionId)
        {
            var parm = new DynamicParameters();
            
            parm.Add("@P_CODE", queryCode, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@QuestionId", questionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<ExamOption> result = dBContext.Connection.Query<ExamOption>("ReturnExamOption", parm, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateExamOption(ExamOption examOption)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@OptionId", examOption.OptionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Description", examOption.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@IsCorrect", examOption.IsCorrect, dbType: DbType.Boolean, direction: ParameterDirection.Input);
            parameters.Add("@QuestionId", examOption.QuestionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@isActive", examOption.IsActive, dbType: DbType.Boolean, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("UpdateExamOption", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Exam> ReturnExamBySectionId(int sectionId)
        {
            var parm = new DynamicParameters();
            parm.Add("@SectionId", sectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Exam> result = dBContext.Connection.Query<Exam>("ReturnExamBySectionId", parm, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        //Section Exam 
        
        public bool InsertSectionExam(SectionExam sectionExam)
        {

            var parm = new DynamicParameters();
            parm.Add("@ExamQuestionId", sectionExam.ExamQuestionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@ExamId", sectionExam.ExamId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("InsertSectionExam", parm, commandType: CommandType.StoredProcedure);
            return true;
        }
        //SectionExamAnswer
        public bool InsertSectionExamAnswer(SectionExamAnswer sectionExamAnswer)
        {
            var parm = new DynamicParameters();
            parm.Add("@SectionExamId",sectionExamAnswer.SectionExamId , dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@AnswerId", sectionExamAnswer.OptionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@TraineeId", sectionExamAnswer.TraineeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("InsertSectionExamAnswer", parm, commandType: CommandType.StoredProcedure);
            return true;
        }
        //<------------------------------------------- Exam DTO ------------------------------------------>
        public List<GetTraineeMarksDTO> GetTraineeMarks(int sectionId)
        {
            throw new NotImplementedException();
        }
        public List<TraineeAnswersDTO> GetTraineeAnswer(int sectionId)
        {
            throw new NotImplementedException();
        }

        public List<ExamFormDTO> GetExamForm(int sectionId)
        {
            throw new NotImplementedException();
        }

        public List<ExamAnswersDTO> GetExamAnswersDTOs(int sectionId)
        {
            throw new NotImplementedException();
        }
        
    }
}
