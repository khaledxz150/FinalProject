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
        public List<Section> ReturnAllSection();
        public Section AddSection(Section section);
        public List<Section> UpdateSection(Section section);
        public bool DeleteSection(int SectionId);

        //Trainee Section
        public TraineeSection AddTraineeSection(TraineeSection traineeSection);
        public bool DeleteTraineeSection(int traineeSectionId);
        public List<TraineeSection> ReturnTraineeSection();
        public List<TraineeSection> UpdateTraineeSection(TraineeSection traineeSection);


        //Trainee Section Task 
        public bool InsertTraineeTask(TraineeSectionTask traineeSectionTask);
        public bool UpdateTraineeTask(TraineeSectionTask traineeSectionTask);
        public bool DeleteTraineeSectionTask(int traineeSectionTaskId);

        //Unit 
        public bool InsertUnit(Unit unit);
        public bool DeleteUnit(int unitId);

        public List<Unit> ReturnSectionUnits(int courseId);

        //Status 
        public bool InsertStatus(Status status);
        public bool UpdateStatus(Status status);
        public bool DeleteStatus(int statusId);
        public Status GetSectionStatus(int sectionId);


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

        public Task AddTask(Task task);
        public List<Task> ReturnAllTask();
        public Task UpdateTask(Task task);




        public TraineeSectionTask AddTraineeSectionTaskId(TraineeSectionTask traineeSectionTask);
        public TraineeSectionTask UpdateTraineeSectionTaskId(TraineeSectionTask traineeSectionTask);
        public List<TraineeSectionTask> SelectTraineeSectionTaskId();

        //ReturnTasksOfSection
        public List<Task> ReturnTasksOfSection(int sectionTrainerId);


        //ReturnSolutionOfTask
        public List<TaskSolutionDTO> ReturnSolutionOfTask(int taskId, int sectionId);

    }
}
