using LMS.Core.DTO;
using LMS.Core.Services;
using LMS.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
        [HttpPost]
        [Route("[action]/{traineeId}")]
        public List<CourseRefundDTO> ReturnCourseRefund(int traineeId)
        {
            return _courseRefundsService.ReturnCourseRefund(traineeId);
        }

        [HttpPost]
        [Route("[action]/{queryCode}")]
        public List<RefundReason> ReturnRefundReason(int queryCode)
        {
            return _courseRefundsService.ReturnRefundReason(queryCode);
        }

        [HttpPost]
        [Route("[action]")]
        public bool InsertRefundReason([FromBody] RefundReason refundReason)
        {
            return _courseRefundsService.InsertRefundReason(refundReason);
        }

        [HttpPut]
        [Route("[action]")]
        public bool UpdateRefundReason([FromBody] RefundReason refundReason)
        {
            return _courseRefundsService.UpdateRefundReason(refundReason);
        }

        [HttpDelete]
        [Route("[action]/{reasonId}")]
        public bool DeleteRefundReason(int reasonId)
        {
            return _courseRefundsService.DeleteRefundReason(reasonId);
        }

    }
}
