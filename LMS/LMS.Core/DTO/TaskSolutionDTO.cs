using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.DTO
{
    public class TaskSolDTO
    {
        public int TraineeSectionTaskId { get; set; }
        public int TraineeSectionId { get; set; }
        public string TraineeName { get; set; }
        public string FileUrl { get; set; }
        public string Note { get; set; }
    }
}
