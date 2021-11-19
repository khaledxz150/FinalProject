using LMS.Core.DTO;
using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LMS.Core.Repository
{
    public interface ISectionRepository
    {
        //Section
        public List<SectionOfTraineeDTO> ReturnSectionOfTrainee(int traineeId, int sectionId);
        public StudentCountDTO ReturnStudentCount(int sectionId);
        public bool AddSection(Section section, int trainerId);

        public bool UpdateSection(Section section, int trainerId);
        public bool DeleteSection(int SectionId);

        public List<Section> GetAllSection();

        //Status

        public List<Status> GetAllStatus();

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

        //ReturnAllTrainerSections
        public List<TrainerSectionDTO> ReturnAllTrainerSections(int trainerId);

        //ReturnSectionByCourseId
        public List<SectionByCourseDTO> ReturnSectionByCourseId(int courseId);

        //ReturnSectionOfTrainee
    

        //ReturnAllComments
        public List<CommentDTO> ReturnAllComments(int sectionId, int queryCode);

        //ReturnUnitBySectionId
        public List<Unit> ReturnUnitBySectionId(int sectionId);

        public bool InsertTask(Tasks task);
        public bool UpdateTask(Tasks task);


        public List<Tasks> SelectTraineeSectionTaskId();



        //ReturnTasksOfSection
        public List<Tasks> ReturnTasksOfSection(int sectionTrainerId);


        //ReturnSolutionOfTask
        public List<SolTaskDTO> ReturnTraineeSolutionOfTask(int taskId, int sectionId);

    }
}
