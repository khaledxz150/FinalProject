using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Data
{
    public class Attendance_Tup
    {
        public int LectureId { set; get; }
        public bool IsPresent { set; get; }
        public bool IsActive { set; get; }
        public DateTime CreationDate { set; get; }
        public long CreatedBy { set; get; }
        public int traineeId { set; get; }
    }
}
