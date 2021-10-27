using LMS.Core.Services;
using LMS.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseRefundsController : ControllerBase
    {

        private readonly ICourseRefundsService _courseRefundsService;

        public CourseRefundsController(ICourseRefundsService courseRefundsService)
        {
            _courseRefundsService=courseRefundsService;
        }

        [HttpPost]
        [Route("[action]")]
        public bool InsertCourseRefunds(CourseRefund courseRefund)
        {
            return _courseRefundsService.InsertCourseRefunds(courseRefund);
        }

        [HttpPut]
        [Route("[action]")]
        public bool UpdateCourseRefunds(CourseRefund courseRefund)
        {
            return _courseRefundsService.UpdateCourseRefunds(courseRefund);
        }

        [HttpPut]
        [Route("[action]/{courseRefundId}")]
        public bool DeleteCourseRefunds(int courseRefundId)
        {
            return _courseRefundsService.DeleteCourseRefunds(courseRefundId);
        }

    }
}
