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
        public StudentCountDTO ReturnStudentCount(int sectionId)
        {
            return sectionRepository.ReturnStudentCount(sectionId);
        }
        //// Section
        ///Start
                //Status

        public List<Status> GetAllStatus()
        {
            return sectionRepository.GetAllStatus();
        }
        public bool AddSection(Section section, int trainerId)
        {
            return sectionRepository.AddSection(section, trainerId);
        }



        public bool DeleteSection(int SectionId)
        {
            return sectionRepository.DeleteSection(SectionId);
        }



       //// Section
       ///End




      //// TraineeSection
      ///Start
        public bool AddTraineeSection(TraineeSection traineeSection)
        {
            return sectionRepository.AddTraineeSection(traineeSection);
        }
        public bool UpdateSection(Section section, int trainerId)
        {
            return sectionRepository.UpdateSection(section, trainerId);
        }

        public bool DeleteTraineeSection(int traineeSectionId)
        {
            return sectionRepository.DeleteTraineeSection(traineeSectionId);
        }


        public bool UpdateTraineeSection(TraineeSection traineeSection)
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

        public List<Unit> ReturnSectionUnits(int sectionId) {
            return sectionRepository.ReturnSectionUnits(sectionId);

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

        public List<CommentDTO> ReturnAllComments(int sectionId, int queryCode)
        {
            return sectionRepository.ReturnAllComments( sectionId,  queryCode);
        }

        public List<Unit> ReturnUnitBySectionId(int sectionId)
        {
            return sectionRepository.ReturnUnitBySectionId(sectionId);
        }

        public bool InsertTask(Tasks task)
        {
            return sectionRepository.InsertTask(task);
        }




        public bool UpdateTask(Tasks task)
        {
            return sectionRepository.UpdateTask(task);
        }


        public List<Tasks> SelectTraineeSectionTaskId()
        {
            return sectionRepository.SelectTraineeSectionTaskId();
        }

        public List<Tasks> ReturnTasksOfSection(int sectionTrainerId)
        {
            return sectionRepository.ReturnTasksOfSection(sectionTrainerId);
        }



        public List<Section> GetAllSection()
        {
            return sectionRepository.GetAllSection();
        }

        public List<TraineeSectionDTO> ReturnTraineeSection(int trainerId)
        {
            return sectionRepository.ReturnTraineeSection(trainerId);
        }

        public List<SolTaskDTO> ReturnTraineeSolutionOfTask(int taskId, int sectionId)
        {
            return sectionRepository.ReturnTraineeSolutionOfTask( taskId,  sectionId);
        }


    }
}
