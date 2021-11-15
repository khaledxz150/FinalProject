using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Repository
{
    public interface ILectureRepository
    {
        public List<Lecture> ReturnLecture(int queryCode);
        public bool InsertLecture(Lecture lecture);
        public bool UpdateLecture(Lecture lecture);
        public bool DeleteLecture(int lectureId);

        //ReturnLectureBySectionId
        public List<Lecture> ReturnLectureBySectionId(int sectionId);

        public List<OffLineLecture> ReturnOffLineLecture(int queryCode);
        public bool InsertOffLineLecture(OffLineLecture offLineLecture);
        public bool UpdateOffLineLecture(OffLineLecture offLineLecture);
        public bool DeleteOffLineLecture(int offLineLectureId);

    }
}
