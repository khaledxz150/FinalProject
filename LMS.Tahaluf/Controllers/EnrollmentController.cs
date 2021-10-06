using LMS.Tahaluf.Core.DTO;
using LMS.Tahaluf.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LMS.Tahaluf.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollmentController : ControllerBase
    {
        private readonly IEnrollmentService _enrollmentService;

        public EnrollmentController(IEnrollmentService service)
        {
            _enrollmentService = service;
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Enrollment>), StatusCodes.Status200OK)]
        public List<Enrollment> getAllEnrolmentsRecord()
        {
            return _enrollmentService.getAllEnrolmentsRecord();
        }
    }
}
