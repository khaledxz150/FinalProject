using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class Employee
    {
      

        public long EmployeeId { get; set; }
        public string NationalSecurutiyNumber { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Image { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreatedBy { get; set; }
        public double BasicSalary { get; set; }

        public virtual RoleType RoleType { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Coupon> Coupons { get; set; }
        public virtual ICollection<CourseRefund> CourseRefunds { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<EvalouationAnswer> EvalouationAnswers { get; set; }
        public virtual ICollection<EvalouationQusetion> EvalouationQusetions { get; set; }
        public virtual ICollection<EvaluationFormsQuestion> EvaluationFormsQuestions { get; set; }
        public virtual ICollection<Evaluation> Evaluations { get; set; }
        public virtual ICollection<ExamOption> ExamOptions { get; set; }
        public virtual ICollection<ExamQuestion> ExamQuestions { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        public virtual ICollection<Lecture> Lectures { get; set; }
        public virtual ICollection<Level> Levels { get; set; }
        public virtual ICollection<Login> Logins { get; set; }
        public virtual ICollection<OffLineLecture> OffLineLectures { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
        public virtual ICollection<Testimonial> TestimonialApprovedEmployees { get; set; }
        public virtual ICollection<Testimonial> TestimonialCreatedByNavigations { get; set; }
        public virtual ICollection<Topic> Topics { get; set; }
        public virtual ICollection<TraineeAttendance> TraineeAttendances { get; set; }
        public virtual ICollection<TraineeSectionExam> TraineeSectionExams { get; set; }
        public virtual ICollection<TraineeSection> TraineeSections { get; set; }
        public virtual ICollection<Trainee> Trainees { get; set; }
        public virtual ICollection<TrainerSection> TrainerSectionCreatedByNavigations { get; set; }
        public virtual ICollection<TrainerSection> TrainerSectionTrainers { get; set; }
        public virtual ICollection<Type> Types { get; set; }
        public virtual ICollection<Unit> Units { get; set; }
    }
}
