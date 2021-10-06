using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.Tahaluf.Core.Data
{
    public class Student
    {
        public int ID {  get; set; }
        public string NAME {  get; set; }
            
        public DateTime? BIRTHDATE {  get; set; }

        public double? MARK { get; set; }

        public ICollection<StudentCourse> studentCourses {  get; set; }
    }
}
