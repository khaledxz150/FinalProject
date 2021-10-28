using LMS.Core.DTO;
using LMS.Core.Repository;
using LMS.Core.Services;
using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LMS.Infra.Services
{
    public class TaskService: ITaskService
    {
        private readonly ITaskRepository TaskRepository;

        public TaskService(ITaskRepository TaskRepository)
        {
            this.TaskRepository = TaskRepository;
        }

        public Task AddTask(Task task)
        {
            return TaskRepository.AddTask(task);
        }

       

        public List<Task> ReturnAllTask()
        {
            return TaskRepository.ReturnAllTask();
        }

        public Task UpdateTask(Task task)
        {
            return TaskRepository.UpdateTask(task);
        }
        
        public TraineeSectionTask AddTraineeSectionTaskId(TraineeSectionTask traineeSectionTask)
        {
            return TaskRepository.AddTraineeSectionTaskId(traineeSectionTask);
        }

        public List<TraineeSectionTask> SelectTraineeSectionTaskId()
        {
            return TaskRepository.SelectTraineeSectionTaskId();
        }

        public TraineeSectionTask UpdateTraineeSectionTaskId(TraineeSectionTask traineeSectionTask)
        {
            return TaskRepository.UpdateTraineeSectionTaskId(traineeSectionTask);
        }

        public List<Task> ReturnTasksOfSection(int sectionTrainerId)
        {
            return TaskRepository.ReturnTasksOfSection(sectionTrainerId);
        }

        public List<TaskSolutionDTO> ReturnSolutionOfTask(int taskId, int sectionId)
        {
            return TaskRepository.ReturnSolutionOfTask(taskId, sectionId);
        }
    }
}
