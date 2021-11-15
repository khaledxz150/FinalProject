using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.DTO
{
    public class UserTestimonailsDTO
    {
        public int TestimonialsId { get; set; }
        public DateTime CreationDate { get; set; }
        public string TraineeName { get; set; }
        public string Description { get; set; }

        public String ImageName {  get; set; }

        public String EmployeeName { get; set; }

        public bool? IsApproved { get; set; }



    }
}
