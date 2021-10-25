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
        private readonly ISectionService sectionRepository;

        public SectionService(ISectionService sectionRepository)
        {
            this.sectionRepository = sectionRepository;
        }

        //// Section 
        ///Start

        public Section AddSection(Section section)
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
        public TraineeSection AddTraineeSection(TraineeSection traineeSection)
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

        public List<TraineeSection> UpdateTraineeSection(TraineeSection traineeSection)
        {
            throw new NotImplementedException();
        }

        //// TraineeSection
        ///End

    }
}
