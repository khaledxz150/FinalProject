using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.DTO
{
    public class CourseRatingDTO
    {
        public int CourseRatingId { get; set; }
        public int NoOfStar { get; set; }
        public string RateNote { get; set; }
        public int SectionId { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseImage { get; set; }
        public string TraineeName { get; set; }
    }
}
