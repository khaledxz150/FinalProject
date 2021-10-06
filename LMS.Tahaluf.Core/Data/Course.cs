using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LMS.Tahaluf.Core.Data
{
   public class Course
    {
        [Key]
        public int CourseId { get; set; }
   
        public string CourseName { get; set; }
        public float? Price { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public ICollection<Book> Books { get; set; }
        public ICollection<TeacherCourse> TeacherCourses { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }


    }
}
