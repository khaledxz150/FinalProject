using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.Tahaluf.Core.Data
{
   public class StudentCourse
    {
        public int ID {  get; set; }
        public int? CourseID {  get; set; }

        public int? STUDENTID { get; set; }

        public virtual Student Student {  get; set; }
    }
}
