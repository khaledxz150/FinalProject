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
            parameters.Add("@SectionId", exam.SectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@ExamDate", exam.ExamDate, dbType: DbType.Date, direction: ParameterDirection.Input);
            parameters.Add("@StartTime", exam.StartTime, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            parameters.Add("@EndTime", exam.EndTime, dbType: DbType.DateTime, direction: ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("UpdateExam", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
