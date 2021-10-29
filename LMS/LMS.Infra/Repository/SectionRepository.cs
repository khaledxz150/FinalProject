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
   public class SectionRepository : ISectionRepository
    {      
        private IDbContext dBContext;
        public SectionRepository(IDbContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public Section AddSection(Section section)
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
            return ReturnAllSection().OrderByDescending(x => x.SectionId).FirstOrDefault();
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


        public TraineeSection AddTraineeSection(TraineeSection traineeSection){

            var parm = new DynamicParameters();
            parm.Add("@P_SectionId", traineeSection.SectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_TraineeId", traineeSection.TraineeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_TotalMark", traineeSection.TotalMark, dbType: DbType.Double, direction: ParameterDirection.Input);
            parm.Add("@P_CreatedBy", traineeSection.TotalMark, dbType: DbType.String, direction: ParameterDirection.Input);      
            IEnumerable<TraineeSection> result = dBContext.Connection.Query<TraineeSection>("AddTraineeSection", parm, commandType: CommandType.StoredProcedure);
            return ReturnTraineeSection().OrderByDescending(x => x.SectionId).FirstOrDefault();
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

        public List<TraineeSection> UpdateTraineeSection(TraineeSection traineeSection)
        {
            throw new NotImplementedException();
        }

        public bool InsertTraineeTask(TraineeSectionTask traineeSectionTask)
        {
            var parm = new DynamicParameters();
            parm.Add("@P_TraineeSectionId",traineeSectionTask.TraineeSectionId , dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_TaskId",traineeSectionTask.TaskId , dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_Note",traineeSectionTask.Note , dbType: DbType.String, direction: ParameterDirection.Input);
            parm.Add("@P_FileUrl", traineeSectionTask.FileUrl, dbType: DbType.String, direction: ParameterDirection.Input);
            parm.Add("@P_Mark",traineeSectionTask.Mark , dbType: DbType.Double, direction: ParameterDirection.Input);
            parm.Add("@P_TrainerNote",traineeSectionTask.TrainerNote , dbType: DbType.String, direction: ParameterDirection.Input);
            parm.Add("@P_CreatedBy",traineeSectionTask.CreatedBy , dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("AddTraineeSectionTask", parm, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool UpdateTraineeTask(TraineeSectionTask traineeSectionTask)
        {
            var parm = new DynamicParameters();

            parm.Add("@P_TraineeSectionId", traineeSectionTask.TraineeSectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_TaskId", traineeSectionTask.TaskId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_Note", traineeSectionTask.Note, dbType: DbType.String, direction: ParameterDirection.Input);
            parm.Add("@P_FileUrl", traineeSectionTask.FileUrl, dbType: DbType.String, direction: ParameterDirection.Input);
            parm.Add("@P_Mark", traineeSectionTask.Mark, dbType: DbType.Double, direction: ParameterDirection.Input);
            parm.Add("@P_TrainerNote", traineeSectionTask.TrainerNote, dbType: DbType.String, direction: ParameterDirection.Input);
            parm.Add("@P_TraineeSectionTaskId", traineeSectionTask.TraineeSectionTaskId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("UpdateTraineeSectionTask", parm, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool DeleteTraineeSectionTask(int traineeSectionTaskId)
        {
            var parm = new DynamicParameters();
            parm.Add("@P_TraineeSectionTaskId", traineeSectionTaskId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("DeleteTraineeSectionTask", parm, commandType: CommandType.StoredProcedure);
            return true;
        }

        //Unit 
        public bool InsertUnit(Unit unit)
        {
            var parm = new DynamicParameters();
            parm.Add("@P_SectionId",unit.SectionId , dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_FilePath", unit.FilePath, dbType: DbType.String, direction: ParameterDirection.Input);
            parm.Add("@P_CreatedBy",unit.CreatedBy , dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("InsertUnit", parm, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool DeleteUnit(int unitId)
        {
            var parm = new DynamicParameters();
            parm.Add("@P_Id", unitId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("DeleteUnit", parm, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Unit> ReturnSectionUnits(int courseId)
        {
            throw new NotImplementedException();
        }

        //Status 
        public bool InsertStatus(Status status)
        {
            throw new NotImplementedException();
        }
        public bool UpdateStatus(Status status)
        {
            throw new NotImplementedException();
        }
        public bool DeleteStatus(int statusId)
        {
            throw new NotImplementedException();
        }
        public Status GetSectionStatus(int sectionId)
        {
            throw new NotImplementedException();
        }

        public List<TrainerSectionDTO> ReturnAllTrainerSections(int trainerId)
        {
            var parm = new DynamicParameters();
            parm.Add("@TrainerId", trainerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<TrainerSectionDTO> result = dBContext.Connection.Query<TrainerSectionDTO>("ReturnAllTrainerSections", parm, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<SectionByCourseDTO> ReturnSectionByCourseId(int courseId)
        {
            var parm = new DynamicParameters();
            parm.Add("@CourseId", courseId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<SectionByCourseDTO> result = dBContext.Connection.Query<SectionByCourseDTO>("ReturnSectionByCourseId", parm, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<SectionOfTraineeDTO> ReturnSectionOfTrainee(int traineeId, int sectionId)
        {
            var parm = new DynamicParameters();
            parm.Add("@TraineeId", traineeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@SectionId", sectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<SectionOfTraineeDTO> result = dBContext.Connection.Query<SectionOfTraineeDTO>("ReturnSectionOfTrainee", parm,commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<CommentDTO> ReturnAllComments(int sectionId)
        {
            var parm = new DynamicParameters();
            parm.Add("@SectionId", sectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<CommentDTO> result = dBContext.Connection.Query<CommentDTO>("ReturnAllComments", parm, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Unit> ReturnUnitBySectionId(int sectionId)
        {
            var Parameter = new DynamicParameters();
            Parameter.Add("@SectionId", sectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Unit> result = dBContext.Connection.Query<Unit>("ReturnUnitBySectionId", Parameter, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
