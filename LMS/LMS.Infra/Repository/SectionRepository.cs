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

namespace LMS.Infra.Repository
{
   public class SectionRepository : ISectionRepository
        //Update Repos
    {      
        private IDbContext dBContext;
        public SectionRepository(IDbContext dBContext)
        {
            this.dBContext = dBContext;
        }

        //Status
        //New Update By Jasser At 9:48

        public List<Status> GetAllStatus()
        {
            
            IEnumerable<Status> result = dBContext.Connection.Query<Status>("ReturnAllStatus", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        //Return All Comment
        public List<CommentDTO> ReturnAllComments(int courseId, int queryCode)
        {
            var parm = new DynamicParameters();

            parm.Add("@QueryCode", queryCode, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@RecordId", courseId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<CommentDTO> result = dBContext.Connection.Query<CommentDTO>("ReturnAllComments", parm, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public List<SectionOfTraineeDTO> ReturnSectionOfTrainee(int traineeId, int sectionId)
        {
            var parm = new DynamicParameters();
            parm.Add("@TraineeId", traineeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@SectionId", sectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<SectionOfTraineeDTO> result = dBContext.Connection.Query<SectionOfTraineeDTO>("ReturnSectionOfTrainee", parm, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool AddSection(Section section, int trainerId)
        {
            var parm = new DynamicParameters();


            parm.Add("@P_CourseId", section.CourseId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_SectionTimeEnd", section.SectionTimeEnd, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            parm.Add("@P_SectionTimeStart", section.SectionTimeStart, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            parm.Add("@P_SectionCapacity", section.SectionCapacity, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_NoLecture", section.NoLecture, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_Status", section.StatusId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_CreatedBy", 1, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_MeetingURL", section.MeetingURL, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("InsertSection", parm, commandType: CommandType.StoredProcedure);

            var sectionId = GetAllSection().OrderByDescending(x => x.SectionId).FirstOrDefault().SectionId;

            var parm1 = new DynamicParameters();
            parm1.Add("@P_TrainerId", trainerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm1.Add("@P_SectionId", sectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm1.Add("@P_CreatedBy", 1, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result1 = dBContext.Connection.ExecuteAsync("InsertTrainerSection", parm1, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool DeleteSection(int SectionId)
        {
            var parm = new DynamicParameters();
            parm.Add("@P_SectionId", SectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("DeleteSection", parm, commandType: CommandType.StoredProcedure);
            return true;
        }


        public bool UpdateSection(Section section, int trainerId)
        {
            var parm = new DynamicParameters();
            parm.Add("@P_SectionId", section.SectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_CourseId", section.CourseId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_SectionCapacity", section.SectionCapacity, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_NoLecture", section.NoLecture, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_Status", section.StatusId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_MeetingURL", section.MeetingURL, dbType: DbType.String, direction: ParameterDirection.Input);
            var result =  dBContext.Connection.ExecuteAsync("UpdateSection", parm, commandType: CommandType.StoredProcedure);
            var parm1 = new DynamicParameters();
            parm1.Add("@P_SectionId", section.SectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm1.Add("@P_TrainerId", trainerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result1 =  dBContext.Connection.ExecuteAsync("UpdateTrainerIdSection", parm1, commandType: CommandType.StoredProcedure);
            return true;
        }


        public bool AddTraineeSection(TraineeSection traineeSection){

            var parm = new DynamicParameters();
            parm.Add("@P_SectionId", traineeSection.SectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_TraineeId", traineeSection.TraineeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
        
            var result = dBContext.Connection.ExecuteAsync("InsertTraineeSection", parm, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteTraineeSection(int traineeSectionId) {

            var parm = new DynamicParameters();
            parm.Add("@P_TraineeSectionId", traineeSectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("DeleteTraineeSection", parm, commandType: CommandType.StoredProcedure);
            return true;
        }


        public bool UpdateTraineeSection(TraineeSection traineeSection)
        {
            var parm = new DynamicParameters();
            parm.Add("@P_TraineeId", traineeSection.TraineeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_TotalMark", traineeSection.TotalMark, dbType: DbType.Double, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("", parm, commandType: CommandType.StoredProcedure);
            return true;
        }


        public List<TraineeNameDTO> ReturnTraineeInSection(int sectionId)
        {
            var parm = new DynamicParameters();
            parm.Add("@P_SectionId", sectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<TraineeNameDTO> result = dBContext.Connection.Query<TraineeNameDTO>("ReturnTraineeBySectionId", parm, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool InsertTraineeTask(TraineeSectionTask traineeSectionTask)
        {
            var parm = new DynamicParameters();
            parm.Add("@P_TraineeSectionId",traineeSectionTask.TraineeSectionId , dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_TaskId",traineeSectionTask.TaskId , dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_Note",traineeSectionTask.Note , dbType: DbType.String, direction: ParameterDirection.Input);
            parm.Add("@P_FileUrl", traineeSectionTask.FileUrl, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("InsertTraineeSectionTask", parm, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool UpdateTraineeTask(TraineeSectionTask traineeSectionTask)
        {
            var parm = new DynamicParameters();
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
            parm.Add("@P_Title", unit.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            parm.Add("@P_FileType", unit.FileType, dbType: DbType.String, direction: ParameterDirection.Input);
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

        public List<Unit> ReturnSectionUnits(int sectionId)
        {
            var parm = new DynamicParameters();
            parm.Add("@SectionId", sectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Unit> result = dBContext.Connection.Query<Unit>("ReturnUnitBySectionId", parm,  commandType: CommandType.StoredProcedure);
            return result.ToList();
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

        public bool InsertTask(Tasks task)
        {
            var parms = new DynamicParameters();

            parms.Add("@P_TaskTitle",task.TaskTitle, dbType: DbType.String, direction: ParameterDirection.Input);
            parms.Add("@P_Mark", task.Mark, dbType: DbType.Double, direction: ParameterDirection.Input);
            parms.Add("@P_Note", task.Note, dbType: DbType.String, direction: ParameterDirection.Input);
            parms.Add("@P_FileType", task.FileType, dbType: DbType.String, direction: ParameterDirection.Input);
            parms.Add("@P_Weight", task.Weight, dbType: DbType.Double, direction: ParameterDirection.Input);
            parms.Add("@P_FileUrl", task.FileUrl, dbType: DbType.String, direction: ParameterDirection.Input);
            parms.Add("@P_Date", task.Date, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            parms.Add("@P_Deadline", task.CreationDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            parms.Add("@P_SectionTrainerId", task.SectionTrainerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
           
            var result = dBContext.Connection.ExecuteAsync("InsertTask", parms, commandType: CommandType.StoredProcedure);
            return true;
        }




        public bool UpdateTask(Tasks task)
        {
            var parm = new DynamicParameters();

            parm.Add("@P_TaskId", task.TaskId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_TaskTitle", task.TaskTitle, dbType: DbType.String, direction: ParameterDirection.Input);
            parm.Add("@P_Mark", task.Mark, dbType: DbType.Double, direction: ParameterDirection.Input);
            parm.Add("@P_Note", task.Note, dbType: DbType.String, direction: ParameterDirection.Input);
            parm.Add("@P_Weight", task.Weight, dbType: DbType.Double, direction: ParameterDirection.Input);
            parm.Add("@P_FileUrl", task.FileUrl, dbType: DbType.String, direction: ParameterDirection.Input);
            parm.Add("@P_Date", task.Date, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            parm.Add("@P_Deadline", task.Deadline, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            parm.Add("@P_SectionTrainerId", task.SectionTrainer, dbType: DbType.Int32, direction: ParameterDirection.Input);
           


            IEnumerable<Section> result = dBContext.Connection.Query<Section>("UpdateTask", parm, commandType: CommandType.StoredProcedure);

            return true;
        }



      
        public List<Tasks> SelectTraineeSectionTaskId()
        {

            IEnumerable<Tasks> result = dBContext.Connection.Query<Tasks>("SelectTraineeSectionTaskId", commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public List<Tasks> ReturnTasksOfSection(int sectionTrainerId)
        {
            var parm = new DynamicParameters();
            parm.Add("@SectionTrainerId", sectionTrainerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Tasks> result = dBContext.Connection.Query<Data.Tasks>("ReturnTasksOfSection", parm,commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        /*public List<TaskSolutionDTO> ReturnTraineeSolutionOfTask(int taskId, int sectionId)
        {
            var parm = new DynamicParameters();
            parm.Add("@TaskId", taskId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@SectionId", sectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<TaskSolutionDTO> result = dBContext.Connection.Query<TaskSolutionDTO>("ReturnSolutionOfTask", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }*/
        public List<SolTaskDTO> ReturnTraineeSolutionOfTask(int taskId, int sectionId)
        {
            var parm = new DynamicParameters();
            parm.Add("@TaskId", taskId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@SectionId", sectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<SolTaskDTO> result = dBContext.Connection.Query<SolTaskDTO>("ReturnSolutionOfTask", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Section> GetAllSection()
        {
            IEnumerable<Section> result = dBContext.Connection.Query<Section>("ReturnAllSection", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }


        public List<TraineeSectionDTO> ReturnTraineeSection(int trainerId)
        {
            var parm = new DynamicParameters();
            parm.Add("@TrainerId", trainerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<TraineeSectionDTO> result = dBContext.Connection.Query<TraineeSectionDTO>("ReturnTraineeSection", parm, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public StudentCountDTO ReturnStudentCount(int sectionId)
        {
            var parm = new DynamicParameters();
            parm.Add("@SectionId", sectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            StudentCountDTO result = dBContext.Connection.QuerySingle<StudentCountDTO>("ReturnSectionStudentCount", parm, commandType: CommandType.StoredProcedure);
            return result;
        }


      

    }
}
