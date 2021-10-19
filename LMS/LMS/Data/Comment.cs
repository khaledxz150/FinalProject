using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class Comment
    {
        public int CommentId { get; set; }
        public string Description { get; set; }
        public int? SectionId { get; set; }
        public int? CourseId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreatedBy { get; set; }

        public virtual Course Course { get; set; }
        public virtual Trainee CreatedByNavigation { get; set; }
        public virtual Section Section { get; set; }
    }
}
