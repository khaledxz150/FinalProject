using LMS.Tahaluf.Core.Data;
using LMS.Tahaluf.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LMS.Tahaluf.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _service;

        public TeacherController(ITeacherService service)
        {
            _service = service;
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Teacher>), StatusCodes.Status200OK)]
        public List<Teacher> GetAllTeacher()
        {
            return _service.GetAllTeacher();
        }

        [HttpGet("{email}")]
        [ProducesResponseType(typeof(List<Teacher>), StatusCodes.Status200OK)]
        public List<Teacher> GetTeachersByEmail(string email)
        {
           return _service.GetTeachersByEmail(email);
        }
    }
}
