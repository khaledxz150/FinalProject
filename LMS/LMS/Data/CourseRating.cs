using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class CourseRating
    {
        public int CourseRatingId { get; set; }
        public short NoOfStar { get; set; }
        public string RateNote { get; set; }
        public int? SectionId { get; set; }
        public int? TraineeId { get; set; }

        public virtual Section Section { get; set; }
        public virtual Trainee Trainee { get; set; }
    }
}
