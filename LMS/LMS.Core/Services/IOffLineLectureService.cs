using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Services
{
    public interface IOffLineLectureService
    {
        public List<OffLineLecture> ReturnOffLineLecture(int queryCode);
        public bool InsertOffLineLecture(OffLineLecture offLineLecture);
        public bool UpdateOffLineLecture(OffLineLecture offLineLecture);
        public bool DeleteOffLineLecture(int offLineLectureId);
    }
}
