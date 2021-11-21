using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.DTO
{
    public class CourseDTO
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public short PassMark { get; set; }
        public decimal CoursePrice { get; set; }
        public string TypeName { get; set; }
        public string Image { get; set; }
        public string PreviewVideoUrl { get; set; }
        public string LevelName { get; set; }
        public string CategoryName { get; set; }
        public string TagName { get; set; }
        public int LevelId { get; set; }
        public int CategoryId { get; set; }
        public int TagId { get; set; }
        public int TypeId { get; set; }

    


    }
}
