using LMS.Core.Services;
using LMS.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public List<TraineeSection> AddTraineeSection(TraineeSection AddTraineeSection)
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



    }
}
