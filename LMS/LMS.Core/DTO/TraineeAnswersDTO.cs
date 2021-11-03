using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.DTO
{
    public class TraineeAnswersDTO
    {
        public int ExamId { get; set; }

        public int SectinId { get; set; }
        public String TraineeName { get; set; }
        public String Answer { get; set;  }

        public String Question { get; set; }


    }
}
