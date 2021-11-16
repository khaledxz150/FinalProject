using Dapper;
using First.Core.Common;
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
           
            queryParameters.Add("@notes",courseRefund.RefundsNotes, dbType: DbType.String, direction: ParameterDirection.Input);
            //execute proc
            var result = dbContext.Connection.ExecuteAsync("InsertCourseRefunds", queryParameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateCourseRefunds(CourseRefund courseRefund)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@CourseRefundsId", courseRefund.CourseRefundsId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            queryParameters.Add("@employeeId", courseRefund.ApprovedEmployeeId, dbType: DbType.Int64, direction: ParameterDirection.Input);
            queryParameters.Add("@isAproved", courseRefund.IsApproved, dbType: DbType.Boolean, direction: ParameterDirection.Input);
            //execute proc
            var result = dbContext.Connection.ExecuteAsync("UpdateCourseRefunds", queryParameters, commandType: CommandType.StoredProcedure);
            return true;
        }
        public List<CourseRefundDTO> ReturnCourseRefund(int traineeId)
        {
            var parm = new DynamicParameters();
            parm.Add("@TraineeId", traineeId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<CourseRefundDTO> result = dbContext.Connection.Query<CourseRefundDTO>("ReturnAllCourseRefunds", parm, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public bool DeleteRefundReason(int reasonId)
        {
            var parm = new DynamicParameters();
            parm.Add("@ReasonId", reasonId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("DeleteRefundReason", parm, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool InsertRefundReason(RefundReason refundReason)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@ReasonDescription", refundReason.ReasonDescription, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("InsertRefundReason", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<RefundReason> ReturnRefundReason(int queryCode)
        {
            var parm = new DynamicParameters();
            parm.Add("@P_CODE", queryCode, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<RefundReason> result = dbContext.Connection.Query<RefundReason>("ReturnRefundReason", parm, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateRefundReason(RefundReason refundReason)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@ReasonId", refundReason.ReasonId, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@ReasonDescription", refundReason.ReasonDescription, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dbContext.Connection.ExecuteAsync("UpdateRefundReason", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool ApproveRefundReason(int CourseRefundsId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@CourseRefundsId", CourseRefundsId, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dbContext.Connection.ExecuteAsync("ApproveRefundReason", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
