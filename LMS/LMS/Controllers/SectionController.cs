using LMS.Core.DTO;
using LMS.Core.Services;
using LMS.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectionController : ControllerBase
    {
        private readonly ISectionService sectionService;

        public SectionController(ISectionService sectionService)
        {
            this.sectionService = sectionService;
        }

        [HttpPost]
        [Route("[action]")]
        public Section AddSection(Section section)
        {
            return sectionService.AddSection(section);
        }
        [HttpDelete]
        [Route("[action]/{SectionId}")]
        public bool DeleteSection(int SectionId)
        {
            return sectionService.DeleteSection(SectionId);
        }
        
        [HttpGet]
        [Route("[action]")]
        public List<Section> ReturnAllSection()
        {
            return sectionService.ReturnAllSection();
        }


        [HttpPut]
        [Route("[action]")]
        public List<Section> UpdateSection(Section section)
        {
            return sectionService.UpdateSection(section);
        }
        /// TraineeSection
        /// Start
        [HttpPost]
        [Route("[action]")]
        public TraineeSection AddTraineeSection(TraineeSection AddTraineeSection)
        {
            return sectionService.AddTraineeSection(AddTraineeSection);
        }

        [HttpPost]
        [Route("[action]")]
        public bool DeleteTraineeSection(int traineeSectionId)
        {
            return sectionService.DeleteTraineeSection(traineeSectionId);
        }

        [HttpGet]
        [Route("[action]")]
        public List<TraineeSection> ReturnTraineeSection()
        {
            return sectionService.ReturnTraineeSection();


        }

        [HttpPut]
        [Route("[action]")]
        public List<TraineeSection> UpdateTraineeSection(TraineeSection AddTraineeSection)
        {
            return sectionService.UpdateTraineeSection(AddTraineeSection);
        }


        //Trainee Section Task 
        [HttpPost]
        [Route("[action]")]
        public bool InsertTraineeTask([FromBody] TraineeSectionTask traineeSectionTask)
        {
            return sectionService.InsertTraineeTask (traineeSectionTask);   
        }
        [HttpPost]
        [Route("[action]")]
        public bool UpdateTraineeTask([FromBody] TraineeSectionTask traineeSectionTask)
        {
            return sectionService.UpdateTraineeTask (traineeSectionTask);
        }
        [HttpDelete]
        [Route("[action]/{traineeSectionTaskId}")]
        public bool DeleteTraineeSectionTask(int traineeSectionTaskId)
        {
            return sectionService.DeleteTraineeSectionTask(traineeSectionTaskId);
        }

        //Unit 
        [HttpPost]
        [Route("[action]")]
        public bool InsertUnit(Unit unit)
        {
            return sectionService.InsertUnit(unit);
        }
        [HttpDelete]
        [Route("[action]/{unitId}")]
        public bool DeleteUnit(int unitId)
        {
            return sectionService.DeleteUnit(unitId);
        }
        [HttpPost]
        [Route("[action]/{courseId}")]
        public List<Unit> ReturnSectionUnits(int courseId)
        {
            return sectionService.ReturnSectionUnits(courseId);
        }

        //Status 
        [HttpPost]
        [Route("[action]")]
        public bool InsertStatus(Status status)
        {
            return sectionService.InsertStatus(status); 
        }
        [HttpPost]
        [Route("[action]")]
        public bool UpdateStatus(Status status)
        {
            return sectionService.UpdateStatus (status);    
        }
        [HttpPost]
        [Route("[action]/{statusId}")]
        public bool DeleteStatus(int statusId)
        {
            return sectionService.DeleteStatus(statusId);
        }

        [HttpPost]
        [Route("[action]/{sectionId}")]
        public Status GetSectionStatus(int sectionId)
        {
            return sectionService.GetSectionStatus(sectionId);
        }


        //ReturnAllTrainerSections
        [HttpPost]
        [Route("[action]/{trainerId}")]
        public List<TrainerSectionDTO> ReturnAllTrainerSections(int trainerId)
        {
            return sectionService.ReturnAllTrainerSections(trainerId);
        }

        //ReturnSectionByCourseId

        [HttpPost]
        [Route("[action]/{courseId}")]
        public List<SectionByCourseDTO> ReturnSectionByCourseId(int courseId)
        {
            return sectionService.ReturnSectionByCourseId(courseId);
        }

        //ReturnSectionOfTrainee

        [HttpPost]
        [Route("[action]/{traineeId}/{sectionId}")]
        public List<SectionOfTraineeDTO> ReturnSectionOfTrainee(int traineeId, int sectionId)
        {
            return sectionService.ReturnSectionOfTrainee(traineeId, sectionId);
        }

        //ReturnAllComments

        [HttpPost]
        [Route("[action]/{sectionId}")]
        public List<CommentDTO> ReturnAllComments(int sectionId)
        {
            return sectionService.ReturnAllComments(sectionId);
        }


        //ReturnUnitBySectionId

        [HttpPost]
        [Route("[action]/{sectionId}")]
        public List<Unit> ReturnUnitBySectionId(int sectionId)
        {
            return sectionService.ReturnUnitBySectionId(sectionId);
        }

        [HttpPost]
        [Route("[action]")]
        public Task AddTask(Task task)
        {
            return sectionService.AddTask(task);
        }


        [HttpGet]
        [Route("[action]")]
        public List<Task> ReturnAllTask()
        {
            return sectionService.ReturnAllTask();
        }

        [HttpPost]
        [Route("[action]")]
        public Task UpdateTask(Task task)
        {
            return sectionService.UpdateTask(task);
        }

        [HttpPost]
        [Route("[action]")]
        public TraineeSectionTask AddTraineeSectionTaskId(TraineeSectionTask traineeSectionTask)
        {
            return sectionService.AddTraineeSectionTaskId(traineeSectionTask);
        }

        [HttpGet]
        [Route("[action]")]
        public List<TraineeSectionTask> SelectTraineeSectionTaskId()
        {
            return sectionService.SelectTraineeSectionTaskId();
        }

        [HttpPost]
        [Route("[action]")]
        public TraineeSectionTask UpdateTraineeSectionTaskId(TraineeSectionTask traineeSectionTask)
        {
            return sectionService.UpdateTraineeSectionTaskId(traineeSectionTask);
        }



        //ReturnTasksOfSection

        [HttpPost]
        [Route("[action]")]
        public List<Task> ReturnTasksOfSection(int sectionTrainerId)
        {
            return sectionService.ReturnTasksOfSection(sectionTrainerId);
        }



        //ReturnSolutionOfTask
        [HttpPost]
        [Route("[action]/{sectionId}/{taskId}")]
        public List<TaskSolutionDTO> ReturnSolutionOfTask(int taskId, int sectionId)
        {
            return sectionService.ReturnSolutionOfTask(taskId, sectionId);
        }
    }
}
