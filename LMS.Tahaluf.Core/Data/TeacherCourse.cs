using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LMS.Tahaluf.Core.Data
{
    public class TeacherCourse
    {[Key]
        public int TeacherCourseId { get; set; }
       
        public int CourseId { get; set; }
   
        public int TeacherId { get; set; }


        [ForeignKey("TeacherId")]
        public virtual Teacher Teacher { get; set; }
        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }


    }
}
