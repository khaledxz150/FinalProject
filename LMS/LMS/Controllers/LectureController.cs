using LMS.Core.Services;
using LMS.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LectureController : ControllerBase
    {
        private readonly ILectureService lectureService;

        public LectureController(ILectureService lectureService)
        {
            this.lectureService = lectureService;

        }

        [HttpPost]
        [Route("[action]/{queryCode}")]
        public List<Lecture> ReturnLecture(int queryCode)
        {
            return lectureService.ReturnLecture(queryCode);
        }

        [HttpPost]
        [Route("[action]")]
        public bool InsertLecture([FromBody] Lecture lecture)
        {
            return lectureService.InsertLecture(lecture);
        }

        [HttpPut]
        [Route("[action]")]
        public bool UpdateLecture([FromBody] Lecture lecture)
        {
            return lectureService.UpdateLecture(lecture);
        }

        [HttpDelete]
        [Route("[action]/{lectureId}")]
        public bool DeleteLecture(int lectureId)
        {
            return lectureService.DeleteLecture(lectureId);
        }



        //ReturnLectureBySectionId
        [HttpPost]
        [Route("[action]/{sectionId}")]
        public List<Lecture> ReturnLectureBySectionId(int sectionId)
        {
            return lectureService.ReturnLectureBySectionId(sectionId);
        }
    }
}
