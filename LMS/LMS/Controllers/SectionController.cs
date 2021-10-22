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
        public List<Section> AddSection(Section section)
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
            return sectionService.AddSection(section);
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



    }
}
