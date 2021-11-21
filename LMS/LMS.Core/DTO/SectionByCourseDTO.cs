using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.DTO
{
    public class SectionByCourseDTO
    {
        public int SectionId { get; set; }
        public int NoLecture { get; set; }
        public int SectionCapacity { get; set; }
        public string StatusName { get; set; }
        public DateTime SectionTimeStart { get; set; }
        public DateTime? SectionTimeEnd { get; set; }
        public string TrainerName { get; set; }
        public int EmployeeId { get; set; }
        public string CourseName { get; set; }
        public int StatusId { get; set; }
        public string MeetingURL { get; set; }
        public int CourseId { get; set; }
    }
}
