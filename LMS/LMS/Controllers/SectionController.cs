using LMS.Core.DTO;
using LMS.Core.Services;
using LMS.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task = LMS.Data.Task;

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
        [HttpGet]
        [Route("[action]")]
        public List<Section> GetAllSection()
        {
            return sectionService.GetAllSection();
        }


        [HttpPost]
        [Route("[action]/{trainerId}")]
        public Task<bool> AddSection(Section section, int trainerId)
        {
            return sectionService.AddSection(section, trainerId);
        }
        [HttpDelete]
        [Route("[action]/{SectionId}")]
        public bool DeleteSection(int SectionId)
        {
            return sectionService.DeleteSection(SectionId);
        }

        [HttpGet]
        [Route("[action]")]
        public List<Status> GetAllStatus()
        {
            return sectionService.GetAllStatus();
        }


        [HttpPut]
        [Route("[action]/{trainerId}")]
        public Task<bool> UpdateSection(Section section, int trainerId)
        {
            return sectionService.UpdateSection(section, trainerId);
        }
        /// TraineeSection
        /// Start
        [HttpPost]
        [Route("[action]")]
        public bool InsertTraineeSection([FromBody]TraineeSection TraineeSection)
        {
            return sectionService.AddTraineeSection(TraineeSection);
        }

        [HttpPost]
        [Route("[action]")]
        public bool DeleteTraineeSection(int traineeSectionId)
        {
            return sectionService.DeleteTraineeSection(traineeSectionId);
        }


        [HttpPut]
        [Route("[action]")]
        public bool UpdateTraineeSection(TraineeSection AddTraineeSection)
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
        [Route("[action]/{sectionId}")]
        public List<Unit> ReturnSectionUnits(int sectionId)
        {
            return sectionService.ReturnSectionUnits(sectionId);
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
        public List<CommentDTO> ReturnAllComments(int sectionId, int queryCode)
        {
            return sectionService.ReturnAllComments(sectionId,1);
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
        public bool AddTask(Task task)
        {
            return sectionService.AddTask(task);
        }




        [HttpPost]
        [Route("[action]")]
        public bool UpdateTask(Task task)
        {
            return sectionService.UpdateTask(task);
        }



        [HttpGet]
        [Route("[action]")]
        public List<Task> SelectTraineeSectionTaskId()
        {
            return sectionService.SelectTraineeSectionTaskId();
        }



        //ReturnTasksOfSection

        [HttpPost]
        [Route("[action]")]
        public List<Task> ReturnTasksOfSection(int sectionTrainerId)
        {
            return sectionService.ReturnTasksOfSection(sectionTrainerId);
        }


        //ReturnTraineeSection

        [HttpPost]
        [Route("[action]/{trainerId}")]
        public List<TraineeSectionDTO> ReturnTraineeSection(int trainerId)
        {
            return sectionService.ReturnTraineeSection(trainerId);
        }


    }
}
