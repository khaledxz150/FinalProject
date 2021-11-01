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
        public TimeSpan SectionTimeStart { get; set; }
        public TimeSpan? SectionTimeEnd { get; set; }
        public string TrainerName { get; set; }
    }
}
