using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LMS.Tahaluf.Core.Data
{
   public class Teacher
    {[Key]
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string Email { get; set; }
        public float Salary { get; set; }
        public string PhoneNumber { get; set; }
        [ForeignKey("LoginId")]
        public int LoginId { get; set; }

        public virtual Login Login { get; set; }
        public ICollection<TeacherCourse>TeacherCourses { set; get; }
    }
}
