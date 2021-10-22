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
   public class SectionRepository : ITaskService
    {
        private IDbContext dBContext;
        public SectionRepository(IDbContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public List<Section> AddSection(Section section)
        {
            var parm = new DynamicParameters();
            parm.Add("@P_CourseId", section.CourseId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_SectionTimeEnd", section.SectionTimeEnd, dbType: DbType.Time, direction: ParameterDirection.Input);
            parm.Add("@P_SectionCapacity", section.SectionCapacity, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_SectionTimeStart", section.SectionTimeStart, dbType: DbType.Time, direction: ParameterDirection.Input);
            parm.Add("@P_NoLecture", section.NoLecture, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_Status", section.Status, dbType: DbType.String, direction: ParameterDirection.Input);
            parm.Add("@P_CreatedBy", section.CreatedBy, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<Section> result = dBContext.Connection.Query<Section>("AddSection", parm, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool DeleteSection(int SectionId)
        {
            var parm = new DynamicParameters();
            parm.Add("@P_SectionId", SectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("DeleteSection", parm, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Section> ReturnAllSection()
        {
            IEnumerable <Section> result = dBContext.Connection.Query<Section>("ReturnAllSection", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Section> UpdateSection(Section section)
        {
            var parm = new DynamicParameters();
            parm.Add("@P_SectionId", section.CourseId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_CourseId", section.CourseId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_SectionTimeEnd", section.SectionTimeEnd, dbType: DbType.Time, direction: ParameterDirection.Input);
            parm.Add("@P_SectionCapacity", section.SectionCapacity, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_SectionTimeStart", section.SectionTimeStart, dbType: DbType.Time, direction: ParameterDirection.Input);
            parm.Add("@P_NoLecture", section.NoLecture, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_Status", section.Status, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<Section> result = dBContext.Connection.Query<Section>("UpdateSection", parm, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }


        public List<TraineeSection> AddTraineeSection(TraineeSection traineeSection){

            var parm = new DynamicParameters();
            parm.Add("@P_SectionId", traineeSection.SectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_TraineeId", traineeSection.TraineeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_TotalMark", traineeSection.TotalMark, dbType: DbType.Double, direction: ParameterDirection.Input);
            parm.Add("@P_CreatedBy", traineeSection.TotalMark, dbType: DbType.String, direction: ParameterDirection.Input);      
            IEnumerable<TraineeSection> result = dBContext.Connection.Query<TraineeSection>("AddTraineeSection", parm, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool DeleteTraineeSection(int traineeSectionId) {

            var parm = new DynamicParameters();
            parm.Add("@P_TraineeSectionId", traineeSectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("DeleteTraineeSection", parm, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<TraineeSection> ReturnTraineeSection()
        {
            IEnumerable<TraineeSection> result = dBContext.Connection.Query<TraineeSection>("ReturnTraineeSection", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

       

    }
}
