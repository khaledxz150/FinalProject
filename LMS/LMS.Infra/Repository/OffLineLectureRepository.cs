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
    public class OffLineLectureRepository: IOffLineLectureRepository
    {
        private IDbContext dBContext;
        public OffLineLectureRepository(IDbContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public bool DeleteOffLineLecture(int offLineLectureId)
        {
            var parm = new DynamicParameters();
            parm.Add("@OfflineLectureId", offLineLectureId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("DeleteOffLineLecture", parm, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool InsertOffLineLecture(OffLineLecture offLineLecture)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@CourseId", offLineLecture.CourseId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@VideoUrl", offLineLecture.VideoUrl, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Description", offLineLecture.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@CreatedBy", offLineLecture.CreatedBy, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("InsertOffLineLecture", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<OffLineLecture> ReturnOffLineLecture(int queryCode)
        {
            var parm = new DynamicParameters();
            parm.Add("@P_CODE", queryCode, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<OffLineLecture> result = dBContext.Connection.Query<OffLineLecture>("ReturnOffLineLecture", parm, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateOffLineLecture(OffLineLecture offLineLecture)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@OfflineLectureId", offLineLecture.OfflineLectureId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@CourseId", offLineLecture.CourseId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@VideoUrl", offLineLecture.VideoUrl, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Description", offLineLecture.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@CreatedBy", offLineLecture.CreatedBy, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("UpdateOffLineLecture", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
