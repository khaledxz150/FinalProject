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
    public class CourseRefundsRepository : ICourseRefundsRepository
    {
        private readonly IDbContext dbContext;

        public CourseRefundsRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public bool DeleteCourseRefunds(int courseRefundId)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@recordId", courseRefundId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            //execute proc
            var result = dbContext.Connection.ExecuteAsync("DeleteCourseRefunds", queryParameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool InsertCourseRefunds(CourseRefund courseRefund)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@TraineeBuyCourseId", courseRefund.TraineeByCourseId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            queryParameters.Add("@RefundsReasonsId", courseRefund.RefundsReasonsId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            queryParameters.Add("@ApprovedEmployeeId", courseRefund.ApprovedEmployeeId, dbType: DbType.Int64, direction: ParameterDirection.Input);
            queryParameters.Add("@notes",courseRefund.RefundsNotes, dbType: DbType.String, direction: ParameterDirection.Input);
            //execute proc
            var result = dbContext.Connection.ExecuteAsync("InsertCourseRefunds", queryParameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateCourseRefunds(CourseRefund courseRefund)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@CourseRefundsId", courseRefund.CourseRefundsId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            queryParameters.Add("@TraineeByCourseId", courseRefund.TraineeByCourseId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            queryParameters.Add("@RefundsReasonsId", courseRefund.RefundsReasonsId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            queryParameters.Add("@employeeId", courseRefund.ApprovedEmployeeId, dbType: DbType.Int64, direction: ParameterDirection.Input);
            queryParameters.Add("@notes", courseRefund.RefundsNotes, dbType: DbType.String, direction: ParameterDirection.Input);
            queryParameters.Add("@isAproved", courseRefund.IsApproved, dbType: DbType.Boolean, direction: ParameterDirection.Input);
            //execute proc
            var result = dbContext.Connection.ExecuteAsync("UpdateCourseRefunds", queryParameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
