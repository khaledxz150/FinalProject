using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.DTO
{
    public class CartItemDTO
    {
        public int CartItemId { get; set; }
        public DateTime CreationDate { get; set; }
        public string CourseName { get; set; }
        public decimal CoursePrice { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int CartId { get; set; }
    }

}
