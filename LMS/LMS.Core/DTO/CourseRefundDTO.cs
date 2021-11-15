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
        public string TraineeName {  get; set; }
        public string Email { get; set; }
        public string ImageName {  get; set; }
        public string Notes {  get; set; }

    }
}
