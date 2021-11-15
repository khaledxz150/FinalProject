using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.DTO
{
    public class CourseRefundDTO
    {
        public string Image { get; set; }
        public string CourseName {  get; set; }
        public double CoursePrice { get; set; }
        public string CreationDate { get; set; }
        public bool   IsApproved { get; set; }
    }
}
