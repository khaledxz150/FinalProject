using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.DTO
{
    public class LiveCourseDTO
    {
        public int SectionId {  get; set; }
        public string Image {  get; set; }
        public string CourseName { get; set; }
        public string TrainerName { get; set; }
        public DateTime SectionTimeStart { get; set; }
        public DateTime SectionTimeEnd { get; set; }

        public string StatusName { get; set; }
        public string Level { get; set; }
    }
}
