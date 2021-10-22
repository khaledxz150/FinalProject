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

        public List<TraineeSectionExam> AddTraineeSectionExam(TraineeSectionExam traineeSectionExam)
        {
            var parm = new DynamicParameters();
            parm.Add("@P_TraineeSectionId", traineeSectionExam.TraineeSectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_ExamId", traineeSectionExam.ExamId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_Mark", traineeSectionExam.ExamId, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            parm.Add("@CreatedBy", traineeSectionExam.CreatedBy, dbType: DbType.Int32, direction: ParameterDirection.Input);

           IEnumerable<TraineeSectionExam> result = dBContext.Connection.Query<TraineeSectionExam>("ReturnExam", parm, commandType: CommandType.StoredProcedure);           
        return result.ToList();
        }

        public bool DeleteTraineeSectionExam(int traineeSectionExamId) {
            var parm = new DynamicParameters();
            parm.Add("@P_TraineeSectionExamId", traineeSectionExamId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("DeleteTraineeSectionExam", parm, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<TraineeSectionExam> ReturnTraineeSectionExam()
        {
            IEnumerable<TraineeSectionExam> result = dBContext.Connection.Query<TraineeSectionExam>("ReturnTraineeSectionExam", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }


        public List<TraineeSectionExam> UpdateTraineeSectionExam(TraineeSectionExam traineeSectionExam)
        {
            var parm = new DynamicParameters();
            parm.Add("@P_TraineeSectionId", traineeSectionExam.TraineeSectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_ExamId", traineeSectionExam.ExamId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_Mark", traineeSectionExam.ExamId, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            IEnumerable<TraineeSectionExam> result = dBContext.Connection.Query<TraineeSectionExam>("UpdateTraineeSectionExam", parm, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }


    }
}
