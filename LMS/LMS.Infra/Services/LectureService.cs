using LMS.Core.Repository;
using LMS.Core.Services;
using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infra.Services
{
    public class LectureService: ILectureService
    {
        private readonly ILectureRepository lectureRepository;

        public LectureService(ILectureRepository lectureRepository)
        {
            this.lectureRepository = lectureRepository;
        }

        public bool DeleteLecture(int lectureId)
        {
            return lectureRepository.DeleteLecture(lectureId);
        }

        public bool InsertLecture(Lecture lecture)
        {
            return lectureRepository.InsertLecture(lecture);
        }

        public List<Lecture> ReturnLecture(int queryCode)
        {
            return lectureRepository.ReturnLecture(queryCode);
        }

        public List<Lecture> ReturnLectureBySectionId(int sectionId)
        {
            return lectureRepository.ReturnLectureBySectionId(sectionId);
        }

        public bool UpdateLecture(Lecture lecture)
        {
            return lectureRepository.UpdateLecture(lecture);
        }
    }
}
