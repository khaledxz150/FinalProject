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
    public class OffLineLectureController : ControllerBase
    {
        private readonly IOffLineLectureService offLineLectureService;

        public OffLineLectureController(IOffLineLectureService offLineLectureService)
        {
            this.offLineLectureService = offLineLectureService;

        }


        [HttpPost]
        [Route("[action]/{queryCode}")]
        public List<OffLineLecture> ReturnOffLineLecture(int queryCode)
        {
            return offLineLectureService.ReturnOffLineLecture(queryCode);
        }

        [HttpPost]
        [Route("[action]")]
        public bool InsertOffLineLecture([FromBody] OffLineLecture offLineLecture)
        {
            return offLineLectureService.InsertOffLineLecture(offLineLecture);
        }

        [HttpPut]
        [Route("[action]")]
        public bool UpdateOffLineLecture([FromBody] OffLineLecture offLineLecture)
        {
            return offLineLectureService.UpdateOffLineLecture(offLineLecture);
        }

        [HttpDelete]
        [Route("[action]/{offLineLectureId}")]
        public bool DeleteOffLineLecture(int offLineLectureId)
        {
            return offLineLectureService.DeleteOffLineLecture(offLineLectureId);
        }
    }
}
