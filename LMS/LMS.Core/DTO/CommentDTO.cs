using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.DTO
{
    public class CommentDTO
    {
        public int CommentId { get; set; }
        public int SectionId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public string TraineeName { get; set; }
    }
}
