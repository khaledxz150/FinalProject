using Dapper;
using First.Core.Common;
using LMS.Core.DTO;
using LMS.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infra.Repository
{
    public class TraineeRepository : ITraineeRepository
    {
        private IDbContext dBContext;
        public TraineeRepository(IDbContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public List<TraineeAttendanceDTO> ReturnTraineeAttendance(int sectionId, int lectureId)
        {
            var parm = new DynamicParameters();
            parm.Add("@SectionId", sectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@LectureId", lectureId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<TraineeAttendanceDTO> result = dBContext.Connection.Query<TraineeAttendanceDTO>("ReturnTraineeAttendance", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<TraineeInfoDTO> ReturnTraineeInfo(int traineeId)
        {
            var parm = new DynamicParameters();
            parm.Add("@TraineeId", traineeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<TraineeInfoDTO> result = dBContext.Connection.Query<TraineeInfoDTO>("ReturnTraineeInfo", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
