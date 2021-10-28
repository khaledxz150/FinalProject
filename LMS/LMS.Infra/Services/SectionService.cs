using LMS.Core.DTO;
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
        private readonly ISectionRepository sectionRepository;

        public SectionService(ISectionRepository sectionRepository)
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
        ///

        //Trainee Section Task 
        public bool InsertTraineeTask(TraineeSectionTask traineeSectionTask)
        {
            return sectionRepository.InsertTraineeTask(traineeSectionTask);
        }
        public bool UpdateTraineeTask(TraineeSectionTask traineeSectionTask)
        {
            return sectionRepository.UpdateTraineeTask  (traineeSectionTask);
        }
        public bool DeleteTraineeSectionTask(int traineeSectionTaskId)
        {
            return sectionRepository.DeleteTraineeSectionTask(traineeSectionTaskId);
        }
        //Unit 
        public bool InsertUnit(Unit unit)
        {
            return sectionRepository.InsertUnit(unit);
        }
        public bool DeleteUnit(int unitId)
        {
            return sectionRepository.DeleteUnit(unitId);
        }

        public List<Unit> ReturnSectionUnits(int courseId) { 
            return sectionRepository.ReturnSectionUnits(courseId);
         
        }

        //Status 
        public bool InsertStatus(Status status)
        {
            return sectionRepository.InsertStatus(status);
        }
        public bool UpdateStatus(Status status)
        {
            return sectionRepository.UpdateStatus   (status);
        }
        public bool DeleteStatus(int statusId)
        {
            return sectionRepository.DeleteStatus(statusId);
        }
        public Status GetSectionStatus(int sectionId)
        {
            return sectionRepository.GetSectionStatus(sectionId);
        }

        public List<TrainerSectionDTO> ReturnAllTrainerSections(int trainerId)
        {
            return sectionRepository.ReturnAllTrainerSections(trainerId);
        }

        public List<SectionByCourseDTO> ReturnSectionByCourseId(int courseId)
        {
            return sectionRepository.ReturnSectionByCourseId(courseId);

        }

        public List<SectionOfTraineeDTO> ReturnSectionOfTrainee(int traineeId, int sectionId)
        {
            return sectionRepository.ReturnSectionOfTrainee(traineeId, sectionId);
        }

        public List<CommentDTO> ReturnAllComments(int sectionId)
        {
            return sectionRepository.ReturnAllComments(sectionId);
        }

        public List<Unit> ReturnUnitBySectionId(int sectionId)
        {
            return sectionRepository.ReturnUnitBySectionId(sectionId);
        }
    }
}
