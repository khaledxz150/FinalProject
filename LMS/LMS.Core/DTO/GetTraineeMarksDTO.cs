using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.DTO
{
    public class GetTraineeMarksDTO
    {
        public int ExamId { get; set; }

        public int SectinId { get; set; }
        public String TraineeName { get; set; }
        public int Mark {  get; set; }
        
    }
}
