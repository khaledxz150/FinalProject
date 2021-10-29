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
            IEnumerable<TraineeAttendanceDTO> result = dBContext.Connection.Query<TraineeAttendanceDTO>("ReturnTraineeAttendance", parm, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<TraineeInfoDTO> ReturnTraineeInfo(int traineeId)
        {
            var parm = new DynamicParameters();
            parm.Add("@TraineeId", traineeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<TraineeInfoDTO> result = dBContext.Connection.Query<TraineeInfoDTO>("ReturnTraineeInfo", parm, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }


        // Add New Trainee 
        public bool InsertTrainee(Trainee trainee)
        {
            var parm = new DynamicParameters();
            parm.Add("@P_FirstName", trainee.FirstName, dbType: DbType.String, direction: ParameterDirection.Input);
            parm.Add("@P_LastName", trainee.LastName, dbType: DbType.String, direction: ParameterDirection.Input);
            parm.Add("@P_PhoneNumber", trainee.PhoneNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            parm.Add("@P_Nationality", trainee.Nationality, dbType: DbType.String, direction: ParameterDirection.Input);
            parm.Add("@P_Email", trainee.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            parm.Add("@P_ImageName", trainee.ImageName, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("AddTrainee", commandType: CommandType.StoredProcedure);
            return true;
        }

        //Update Trainee 
        public bool UpdateTrainee(Trainee trainee)
        {
            var parm = new DynamicParameters();
            parm.Add("@P_TraineeId", trainee.TraineeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_FirstName", trainee.FirstName, dbType: DbType.String, direction: ParameterDirection.Input);
            parm.Add("@P_LastName", trainee.LastName, dbType: DbType.String, direction: ParameterDirection.Input);
            parm.Add("@P_PhoneNumber", trainee.PhoneNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            parm.Add("@P_Nationality", trainee.Nationality, dbType: DbType.String, direction: ParameterDirection.Input);
            parm.Add("@P_Email", trainee.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            parm.Add("@P_ImageName", trainee.ImageName, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("UpdateTrainee", commandType: CommandType.StoredProcedure);
            return true;
        }

        //Delete Trainee
        public bool DeleteTrainee(int traineeId)
        {
            var parm = new DynamicParameters();
          
            parm.Add("@P_TraineeId", traineeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("DeleteTrainee", commandType: CommandType.StoredProcedure);
            return true;
        }

    }
}
