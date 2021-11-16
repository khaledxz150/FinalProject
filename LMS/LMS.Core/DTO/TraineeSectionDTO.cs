using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.DTO
{
    public class TraineeSectionDTO
    {

        public int TraineeSectionId { get; set; }
        public int SectionId { get; set; }
        public int TotalMark { get; set; }
        public int SectionCapacity { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string TraineeName { get; set; }
        public int TraineeId { get; set; }
        public int TrainerId { get; set; }




    }
}
