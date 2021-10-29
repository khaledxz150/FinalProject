using LMS.Core.DTO;
using LMS.Core.Services;
using LMS.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService TaskService;

        public TaskController(ITaskService TaskService)
        {
            this.TaskService = TaskService;

        }


        [HttpPost]
        [Route("[action]")]
        public Task AddTask(Task task)
        {
            return TaskService.AddTask(task);
        }


        [HttpGet]
        [Route("[action]")]
        public List<Task> ReturnAllTask()
        {
            return TaskService.ReturnAllTask();
        }

        [HttpPost]
        [Route("[action]")]
        public Task UpdateTask(Task task)
        {
            return TaskService.UpdateTask(task);
        }

        [HttpPost]
        [Route("[action]")]
        public TraineeSectionTask AddTraineeSectionTaskId(TraineeSectionTask traineeSectionTask)
        {
            return TaskService.AddTraineeSectionTaskId(traineeSectionTask);
        }

        [HttpGet]
        [Route("[action]")]
        public List<TraineeSectionTask> SelectTraineeSectionTaskId()
        {
            return TaskService.SelectTraineeSectionTaskId();
        }

        [HttpPost]
        [Route("[action]")]
        public TraineeSectionTask UpdateTraineeSectionTaskId(TraineeSectionTask traineeSectionTask)
        {
            return TaskService.UpdateTraineeSectionTaskId(traineeSectionTask);
        }



        //ReturnTasksOfSection

        [HttpPost]
        [Route("[action]/{sectionTrainerId}")]
        public List<Task> ReturnTasksOfSection(int sectionTrainerId)
        {
            return TaskService.ReturnTasksOfSection(sectionTrainerId);
        }



        //ReturnSolutionOfTask
        [HttpPost]
        [Route("[action]/{sectionId}/{taskId}")]
        public List<TaskSolutionDTO> ReturnSolutionOfTask(int taskId, int sectionId)
        {
            return TaskService.ReturnSolutionOfTask(taskId, sectionId);
        }
    }
}
