using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LMS.Core.DTO;
using LMS.Data;

namespace LMS.Core.Repository
{
    public interface ITaskRepository
    {
        public Task AddTask(Task task);
        public Task UpdateTask(Task task);
        public List<Task> ReturnAllTask ();



        public TraineeSectionTask AddTraineeSectionTaskId(TraineeSectionTask traineeSectionTask);

        public List<TraineeSectionTask> SelectTraineeSectionTaskId();

        public TraineeSectionTask UpdateTraineeSectionTaskId(TraineeSectionTask traineeSectionTask);


        //ReturnTasksOfSection
        public List<Task> ReturnTasksOfSection(int sectionTrainerId);


        //ReturnSolutionOfTask
        public List<TaskSolutionDTO> ReturnSolutionOfTask(int taskId, int sectionId);

    }
}
