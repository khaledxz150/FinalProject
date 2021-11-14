using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.DTO
{
    public class MySectionsDTO
    {
        public int TraineeSectionId {  get; set; }
        public DateTime CreationDate {  get; set; }
        public string TrainerName { get; set; } 
        public string Image { get; set; }
        public string CourseName { get; set;  }
        public int NoLecture { get; set; }
        public string TypeName { get; set; }
        public string CourseDescription { get; set; }
        public DateTime SectionTimeStart { get; set; }
        public DateTime SectionTimeEnd {  get; set;}
    }
}
