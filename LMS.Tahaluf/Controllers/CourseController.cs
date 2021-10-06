using LMS.Tahaluf.Core.Data;
using LMS.Tahaluf.Core.DTO;
using LMS.Tahaluf.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Tahaluf.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]

        [ProducesResponseType(typeof(List<Course>), StatusCodes.Status200OK)]
        public List<Course> GetAllCourse()
        {
            return _courseService.GetAllCourse();
        }

        [HttpPost]

        [ProducesResponseType(typeof(List<Course>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public bool CreateCourse(Course course)

        {
            return _courseService.CreateCourse(course);
        }

        [HttpDelete ("{id}")]
        
        [ProducesResponseType(typeof(List<Course>), StatusCodes.Status200OK)]
        public bool DeleteCourse(int id)
        {
            return _courseService.DeleteCourse(id);
        }

        [HttpGet]
        [Route ("getByCoursePrice/{price}")]
        [ProducesResponseType(typeof(List<Course>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Course> GetByCoursePrice(double price)
        {
            return _courseService.GetByCoursePrice(price);
        }

        [HttpGet]
        [Route("GetByCourseName")]
        [ProducesResponseType(typeof(List<Course>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Course> GetByCourseName(String courseName)
        {
            return _courseService.GetByCourseName(courseName);
        }

        [HttpGet]
        [Route("GetByCourseName2")]
        [ProducesResponseType(typeof(List<Course>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Course> GetByCourseName([FromBody]Course course)
        {
            return _courseService.GetByCourseName(course);
        }

        [HttpGet]
        [Route("SearchBetweenates")]
        [ProducesResponseType(typeof(List<Course>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Course> GetCourseBetweenDate(SearchBetweenates dates)
        {
            return _courseService.GetCourseBetweenDate(dates);
        }
    }
}
