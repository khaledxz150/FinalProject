using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class Section
    {
     

        public int SectionId { get; set; }
        public int CourseId { get; set; }
        public DateTime SectionTimeStart { get; set; }
        public DateTime SectionTimeEnd { get; set; }
        public int SectionCapacity { get; set; }
        public int NoLecture { get; set; }
        public int StatusId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public long CreatedBy { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<CourseRating> CourseRatings { get; set; }
        public virtual ICollection<Evaluation> Evaluations { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        public virtual ICollection<Lecture> Lectures { get; set; }
        public virtual ICollection<TraineeSection> TraineeSections { get; set; }
        public virtual ICollection<Unit> Units { get; set; }
    }
}
