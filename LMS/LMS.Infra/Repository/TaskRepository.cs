using Dapper;
using First.Core.Common;
using LMS.Core.Repository;
using LMS.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LMS.Infra.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private IDbContext dBContext;
        public TaskRepository(IDbContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public Task AddTask(Task task)
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
            parm.Add("@P_CreatedBy", task.CreatedBy, dbType: DbType.String, direction: ParameterDirection.Input);


            IEnumerable<Section> result = dBContext.Connection.Query<Section>("AddTask", parm, commandType: CommandType.StoredProcedure);
           
            return ReturnAllTask().OrderByDescending(x => x.TaskId).FirstOrDefault();
        }

       

        public List<Task> ReturnAllTask()
        {
            IEnumerable<Task> result = dBContext.Connection.Query<Task>("ReturnAllTask", commandType: CommandType.StoredProcedure);
            return result.ToList();
            
        }

        public Task UpdateTask(Task task)
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
            parm.Add("@P_CreatedBy", task.CreatedBy, dbType: DbType.String, direction: ParameterDirection.Input);


            IEnumerable<Section> result = dBContext.Connection.Query<Section>("UpdateTask", parm, commandType: CommandType.StoredProcedure);
           
            return ReturnAllTask().OrderByDescending(x => x.TaskId = task.TaskId ).FirstOrDefault();     
        }
        
        public TraineeSectionTask AddTraineeSectionTaskId(TraineeSectionTask traineeSectionTask)
        {
            var parm = new DynamicParameters();
            parm.Add("@P_TraineeSectionId", traineeSectionTask.TraineeSectionTaskId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_TaskId", traineeSectionTask.TaskId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_Note", traineeSectionTask.Note, dbType: DbType.String, direction: ParameterDirection.Input);
            parm.Add("@P_FileUrl", traineeSectionTask.FileUrl, dbType: DbType.String, direction: ParameterDirection.Input);
            parm.Add("@P_Mark", traineeSectionTask.Mark, dbType: DbType.Double, direction: ParameterDirection.Input);
            parm.Add("@P_CreatedBy", traineeSectionTask.CreatedBy, dbType: DbType.String, direction: ParameterDirection.Input);



            IEnumerable<TraineeSectionTask> result = dBContext.Connection.Query<TraineeSectionTask>("AddTraineeSectionTaskId", parm, commandType: CommandType.StoredProcedure);

            return SelectTraineeSectionTaskId().OrderByDescending(x => x.TraineeSectionTaskId).FirstOrDefault();
        }


        public TraineeSectionTask UpdateTraineeSectionTaskId(TraineeSectionTask traineeSectionTask)
        {
            var parm = new DynamicParameters();
          parm.Add("@P_TraineeSectionTaskId", traineeSectionTask.TraineeSectionTaskId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_TraineeSectionId", traineeSectionTask.TraineeSectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
           
            parm.Add("@P_TaskId", traineeSectionTask.TaskId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@P_Note", traineeSectionTask.Note, dbType: DbType.String, direction: ParameterDirection.Input);
            parm.Add("@P_FileUrl", traineeSectionTask.FileUrl, dbType: DbType.String, direction: ParameterDirection.Input);
            parm.Add("@P_Mark", traineeSectionTask.Mark, dbType: DbType.Double, direction: ParameterDirection.Input);
            parm.Add("@P_CreatedBy", traineeSectionTask.CreatedBy, dbType: DbType.String, direction: ParameterDirection.Input);



            IEnumerable<TraineeSectionTask> result = dBContext.Connection.Query<TraineeSectionTask>("UpdateTraineeSectionTaskId", parm, commandType: CommandType.StoredProcedure);

            return SelectTraineeSectionTaskId().OrderByDescending(x => x.TraineeSectionTaskId = traineeSectionTask.TraineeSectionTaskId).FirstOrDefault();
        } 
        public List<TraineeSectionTask> SelectTraineeSectionTaskId()
        {

            IEnumerable<TraineeSectionTask> result = dBContext.Connection.Query<TraineeSectionTask>("SelectTraineeSectionTaskId", commandType: CommandType.StoredProcedure);

            return result.ToList();
        }


    }

}
