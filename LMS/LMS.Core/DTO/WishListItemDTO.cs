using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.DTO
{
    public class WishListItemDTO
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public decimal CoursePrice { get; set; }
    }
}
