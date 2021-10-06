using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LMS.Tahaluf.Core.Data
{
   public class Book
    {[Key]
        public int BookId { get; set; }
        public string BookName { get; set; }
        public float? Price { get; set; }
        public DateTime? PublishedDate { get; set; }
        public DateTime? EndDate { get; set; }
        [ForeignKey("CourseId")]
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
