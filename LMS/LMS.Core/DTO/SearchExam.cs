using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.DTO
{
    public class SearchExam
    {
        public DateTime MinDate{ get; set; }
        public DateTime MaxDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public  int MinMark { get; set; }
        public int MaxMark { get; set; }
        public int Weight { get; set; }

    }
}
