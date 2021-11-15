using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.DTO
{
    public class SectionOfTraineeDTO
    {
        public int CourseId { get; set; }
        public double CoursePrice { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string CourseName { get; set; }
        public short PassMark { get; set; }
        public string CategoryName { get; set; }
        public string TagName { get; set; }
        public string LevelName { get; set; }
        public string TypeName { get; set; }
        public string TrainerName { get; set; }
        public decimal? TotalMark { get; set; }
    }

}
