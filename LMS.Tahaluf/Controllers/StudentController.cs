using LMS.Tahaluf.Core.Data;
using LMS.Tahaluf.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LMS.Tahaluf.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;
        
        public StudentController(IStudentService service)
        {
            _service=service;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Student>),StatusCodes.Status200OK)]
        public List<Student> GetAllStudent()
        {
            return _service.GetAllStudent();
        }


    }
}
