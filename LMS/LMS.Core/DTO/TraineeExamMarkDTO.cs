using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.DTO
{
    public partial class TraineeExamMarkDTO
    {
        public int ExamId { get; set; }
        public DateTime EndTime { get; set; }
        public string TraineeName { get; set; }
        public string Email { get; set; }
        public int TraineeMark { get; set; }
    }
}