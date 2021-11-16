using LMS.Core.DTO;
using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = LMS.Data.Task;

namespace LMS.Core.Services
{
    public interface ISectionService
    {
        //Section

        public Task<bool> AddSection(Section section, int trainerId);

        public Task<bool> UpdateSection(Section section, int trainerId);
        public bool DeleteSection(int SectionId);
        public List<Section> GetAllSection();


        //Trainee Section
        public bool AddTraineeSection(TraineeSection traineeSection);
        public bool DeleteTraineeSection(int traineeSectionId);
      
        public bool UpdateTraineeSection(TraineeSection traineeSection);
        public List<TraineeSectionDTO> ReturnTraineeSection(int trainerId);


        //Trainee Section Task 
        public bool InsertTraineeTask(TraineeSectionTask traineeSectionTask);
        public bool UpdateTraineeTask(TraineeSectionTask traineeSectionTask);
        public bool DeleteTraineeSectionTask(int traineeSectionTaskId);

      
        //Unit 
        public bool InsertUnit(Unit unit);
        public bool DeleteUnit(int unitId);

        public List<Unit> ReturnSectionUnits(int sectionId);

        //Status

        public List<Status> GetAllStatus();

        //ReturnAllTrainerSections
        public List<TrainerSectionDTO> ReturnAllTrainerSections(int trainerId);

        //ReturnSectionByCourseId
        public List<SectionByCourseDTO> ReturnSectionByCourseId(int courseId);

        //ReturnSectionOfTrainee
        public List<SectionOfTraineeDTO> ReturnSectionOfTrainee(int traineeId, int sectionId);

        //ReturnAllComments
        public List<CommentDTO> ReturnAllComments(int sectionId, int queryCode);

        //ReturnUnitBySectionId
        public List<Unit> ReturnUnitBySectionId(int sectionId);

        public bool AddTask(Task task);
        
        public bool UpdateTask(Task task);



        public List<TraineeSectionTask> SelectTraineeSectionTaskId();

        //ReturnTasksOfSection
        public List<Task> ReturnTasksOfSection(int sectionTrainerId);


        //ReturnSolutionOfTask
        public List<TaskSolutionDTO> ReturnSolutionOfTask(int taskId, int sectionId);

    }
}
