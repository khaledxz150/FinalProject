using LMS.Core.Repository;
using LMS.Core.Services;
using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infra.Services
{
    public class SectionService: ISectionService
    {
        private readonly ITaskService sectionRepository;

        public SectionService(ITaskService sectionRepository)
        {
            this.sectionRepository = sectionRepository;
        }

        //// Section 
        ///Start

        public List<Section> AddSection(Section section)
        {
            return sectionRepository.AddSection(section);              
        }

       

        public bool DeleteSection(int SectionId)
        {
            return sectionRepository.DeleteSection(SectionId);
        }

        

        public List<Section> ReturnAllSection()
        {
            return sectionRepository.ReturnAllSection();
        }

       //// Section
       ///End




      //// TraineeSection
      ///Start
        public List<TraineeSection> AddTraineeSection(TraineeSection traineeSection)
        {
            return sectionRepository.AddTraineeSection(traineeSection);
        }
        public List<Section> UpdateSection(Section section)
        {
            return sectionRepository.UpdateSection(section);
        }
        
        public bool DeleteTraineeSection(int traineeSectionId)
        {
            return sectionRepository.DeleteTraineeSection(traineeSectionId);
        }

        public List<TraineeSection> ReturnTraineeSection()
        {
            return sectionRepository.ReturnTraineeSection();
        }

        //// TraineeSection
        ///End

    }
}
