using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.DTO
{
    public class TrainerSectionDTO
    {
        public int TrainerSectionId { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseImage { get; set; }
        public string LevelName { get; set; }
        public string CategoryName { get; set; }
        public int NoLecture { get; set; }
        public int SectionCapacity { get; set; }
        public string StatusName { get; set; }
        public int? SectionId { get; set; }
        public DateTime SectionTimeStart { get; set; }
        public DateTime? SectionTimeEnd { get; set; }

        public bool? IsActive { get; set; }

    }
}
