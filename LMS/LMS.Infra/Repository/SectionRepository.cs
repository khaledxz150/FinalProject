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
using Task = LMS.Data.Task;

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

        public async Task<bool> AddSection(Section section, int trainerId)
        {
            var parm = new DynamicParameters();


            parm.Add("@P_CourseId", section.CourseId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_SectionTimeEnd", section.SectionTimeEnd, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            parm.Add("@P_SectionCapacity", section.SectionCapacity, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_SectionTimeStart", section.SectionTimeStart, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            parm.Add("@P_NoLecture", section.NoLecture, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_Status", section.StatusId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_CreatedBy", section.CreatedBy, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = await dBContext.Connection.ExecuteAsync("InsertSection", parm, commandType: CommandType.StoredProcedure);

            var sectionId = GetAllSection().OrderByDescending(x => x.SectionId).FirstOrDefault().SectionId;

            var parm1 = new DynamicParameters();
            parm1.Add("@P_TrainerId", trainerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm1.Add("@P_SectionId", sectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm1.Add("@P_CreatedBy", section.CreatedBy, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result1 = await dBContext.Connection.ExecuteAsync("InsertTrainerSection", parm1, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool DeleteSection(int SectionId)
        {
            var parm = new DynamicParameters();
            parm.Add("@P_SectionId", SectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("DeleteSection", parm, commandType: CommandType.StoredProcedure);
            return true;
        }


        public async Task<bool> UpdateSection(Section section, int trainerId)
        {
            var parm = new DynamicParameters();
            parm.Add("@P_SectionId", section.SectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_CourseId", section.CourseId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_SectionCapacity", section.SectionCapacity, dbType: DbType.Int32, direction: ParameterDirection.Input);

            parm.Add("@P_NoLecture", section.NoLecture, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_Status", section.StatusId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = await dBContext.Connection.ExecuteAsync("UpdateSection", parm, commandType: CommandType.StoredProcedure);



            var parm1 = new DynamicParameters();
            parm1.Add("@P_SectionId", section.SectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm1.Add("@P_TrainerId", trainerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result1 = await dBContext.Connection.ExecuteAsync("UpdateTrainerIdSection", parm1, commandType: CommandType.StoredProcedure);
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

        public bool AddTask(Task task)
        {
            var parm = new DynamicParameters();
            parm.Add("@P_TaskTitle", task.TaskTitle, dbType: DbType.String, direction: ParameterDirection.Input);
            parm.Add("@P_Mark", task.Mark, dbType: DbType.Double, direction: ParameterDirection.Input);
            parm.Add("@P_Note", task.Note, dbType: DbType.String, direction: ParameterDirection.Input);
            parm.Add("@P_Weight", task.Weight, dbType: DbType.Double, direction: ParameterDirection.Input);
            parm.Add("@P_FileUrl", task.FileUrl, dbType: DbType.String, direction: ParameterDirection.Input);
            parm.Add("@P_Date", task.Date, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            parm.Add("@P_Deadline", task.Deadline, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            parm.Add("@P_SectionTrainerId", task.SectionTrainer, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Section> result = dBContext.Connection.Query<Section>("AddTask", parm, commandType: CommandType.StoredProcedure);
            return true;
        }



        public List<Task> ReturnAllTask()
        {
            IEnumerable<Task> result = dBContext.Connection.Query<Task>("ReturnAllTask", commandType: CommandType.StoredProcedure);
            return result.ToList();

        }

        public bool UpdateTask(Task task)
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



      
        public List<TraineeSectionTask> SelectTraineeSectionTaskId()
        {

            IEnumerable<TraineeSectionTask> result = dBContext.Connection.Query<TraineeSectionTask>("SelectTraineeSectionTaskId", commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public List<Task> ReturnTasksOfSection(int sectionTrainerId)
        {
            var parm = new DynamicParameters();
            parm.Add("@SectionTrainerId", sectionTrainerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Task> result = dBContext.Connection.Query<Data.Task>("ReturnTasksOfSection", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<TaskSolutionDTO> ReturnSolutionOfTask(int taskId, int sectionId)
        {
            var parm = new DynamicParameters();
            parm.Add("@TaskId", taskId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@SectionId", sectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<TaskSolutionDTO> result = dBContext.Connection.Query<TaskSolutionDTO>("ReturnSolutionOfTask", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Section> GetAllSection()
        {
            IEnumerable<Section> result = dBContext.Connection.Query<Section>("ReturnAllSection", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
