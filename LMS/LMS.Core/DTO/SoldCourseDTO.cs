using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.DTO
{
    public class SoldCourseDTO
    {
        public int CheckoutId { get; set; }
        public int CartId { get; set; }
        public int CartItemId { get; set; }
        public int CourseId { get; set; }

        public int TraineeId { get; set; }
        public DateTime CreationDate { get; set; }
        public string CourseName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TraineeImage { get; set; }
        public int PhoneNumber { get; set; }
        public decimal CoursePrice { get; set; }
    }
}
