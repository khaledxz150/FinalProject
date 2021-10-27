using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class Topic
    {
        public int Id { get; set; }
        public string TopicName { get; set; }
        public int CourseId { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public long CreatedBy { get; set; }

        public virtual Course Course { get; set; }
        public virtual Employee CreatedByNavigation { get; set; }
    }
}
