using LMS.Core.DTO;
using LMS.Core.Repository;
using LMS.Core.Services;
using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


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
                //Status

        public List<Status> GetAllStatus()
        {
            return sectionRepository.GetAllStatus();
        }
        public bool AddSection(Section section)
        {
            return sectionRepository.AddSection(section);              
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
        public bool UpdateSection(Section section)
        {
            return sectionRepository.UpdateSection(section);
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

        public bool AddTask(Task task)
        {
            return sectionRepository.AddTask(task);
        }




        public bool UpdateTask(Task task)
        {
            return sectionRepository.UpdateTask(task);
        }


        public List<TraineeSectionTask> SelectTraineeSectionTaskId()
        {
            return sectionRepository.SelectTraineeSectionTaskId();
        }

        public List<Task> ReturnTasksOfSection(int sectionTrainerId)
        {
            return sectionRepository.ReturnTasksOfSection(sectionTrainerId);
        }

        public List<TaskSolutionDTO> ReturnSolutionOfTask(int taskId, int sectionId)
        {
            return sectionRepository.ReturnSolutionOfTask(taskId, sectionId);
        }
    }
}
