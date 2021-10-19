
using Dapper;
using First.Core.Common;
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
   public class ExamQuestionRepository: IExamQuestionRepository
    {
        private IDbContext dBContext;
        public ExamQuestionRepository(IDbContext dBContext)
        {
            this.dBContext = dBContext;
        }

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
            parameters.Add("@CourseId", examQuestion.QuestionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@CreatedBy", examQuestion.CreatedBy, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("InsertExamQuestion", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<ExamQuestion> ReturnExamQuestion(int queryCode)
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
            parameters.Add("@CourseId", examQuestion.QuestionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@CreatedBy", examQuestion.CreatedBy, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("UpdateExamQuestion", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
