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
    public class ExamOptionRepository: IExamOptionRepository
    {
        private IDbContext dBContext;
        public ExamOptionRepository(IDbContext dBContext)
        {
            this.dBContext = dBContext;
        }

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
            parameters.Add("@CreatedBy", examOption.CreatedBy, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("InsertExamOption", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<ExamOption> ReturnExamOption(int queryCode)
        {
            var parm = new DynamicParameters();
            parm.Add("@P_CODE", queryCode, dbType: DbType.Int32, direction: ParameterDirection.Input);

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
            parameters.Add("@CreatedBy", examOption.CreatedBy, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("UpdateExamOption", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
