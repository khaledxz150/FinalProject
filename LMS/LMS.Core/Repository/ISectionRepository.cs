﻿using LMS.Core.DTO;
using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Repository
{
    public interface ISectionRepository
    {
        //Section
        public Section AddSection(Section section);
        public List<Section> UpdateSection(Section section);
        public List<Section> ReturnAllSection();
        
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
        public List<CommentDTO> ReturnAllComments(int sectionId);

        //ReturnUnitBySectionId
        public List<Unit> ReturnUnitBySectionId(int sectionId);
    }
}