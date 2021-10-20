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
   public class RefundReasonRepository: IRefundReasonRepository
    {
        private IDbContext dBContext;
        public RefundReasonRepository(IDbContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public bool DeleteRefundReason(int reasonId)
        {
            var parm = new DynamicParameters();
            parm.Add("@ReasonId", reasonId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("DeleteRefundReason", parm, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool InsertRefundReason(RefundReason refundReason)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@ReasonDescription", refundReason.ReasonDescription, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("InsertRefundReason", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<RefundReason> ReturnRefundReason(int queryCode)
        {
            var parm = new DynamicParameters();
            parm.Add("@P_CODE", queryCode, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<RefundReason> result = dBContext.Connection.Query<RefundReason>("ReturnRefundReason", parm, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateRefundReason(RefundReason refundReason)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@ReasonId", refundReason.ReasonId, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@ReasonDescription", refundReason.ReasonDescription, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("UpdateRefundReason", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
