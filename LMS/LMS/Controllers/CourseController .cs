using LMS.Core.Services;
using LMS.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LMS.Controllers
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
        [HttpPost]
        [Route("[action]")]
        public bool AddNewCategory([FromBody] Category category)
        {
            return _courseService.AddNewCategory(category);
        }
        [HttpPost]
        [Route("[action]")]
        public bool AddNewComment([FromBody] Comment comment)
        {
            return _courseService.AddNewComment(comment);
        }
        [HttpPost]
        [Route("[action]")]
        public bool AddNewCourse([FromBody] Course course)
        {
            return _courseService.AddNewCourse(course);
        }
        [HttpPost]
        [Route("[action]")]
        public bool AddNewTopic([FromBody] Topic topic)
        {
            return _courseService.AddNewTopic(topic);
        }
        [HttpPut]
        [Route("[action]/{categoryId}")]
        public bool DeleteCategory(int categoryId)
        {
            return _courseService.DeleteCategory(categoryId);
        }
        [HttpPut]
        [Route("[action]/{commentId}")]
        public bool DeleteComment(int commentId)
        {
            return _courseService.DeleteComment(commentId);
        }
        [HttpPut]
        [Route("[action]/{courseId}")]
        public bool DeleteCourse(int courseId)
        {
            return _courseService.DeleteCourse(courseId);
        }
        [HttpPut]
        [Route("[action]/{tagId}")]
        public bool DeleteTag(int tagId)
        {
            return _courseService.DeleteTag(tagId);
        }
        [HttpPut]
        [Route("[action]/{topicId}")]
        public bool DeleteTopic(int topicId)
        {
            return _courseService.DeleteTopic(topicId);
        }
        [HttpPut]
        [Route("[action]/{queryCode}")]
        public List<Category> GetAllCategories(int queryCode)
        {
            return _courseService.GetAllCategories(queryCode);
        }
        [HttpPut]
        [Route("[action]/{queryCode}")]
        public List<Comment> GetAllCommentForCourse(int queryCode)
        {
            return _courseService.GetAllCommentForCourse(queryCode);
        }
        [HttpPut]
        [Route("[action]/{queryCode}")]
        public List<Course> GetAllCourse(int queryCode)
        {
            return _courseService.GetAllCourse(queryCode);
        }
        [HttpGet]
        [Route("[action]")]
        public List<Tag> GetAllTags()
        {
            return _courseService.GetAllTags();
        }
        [HttpGet]
        [Route("[action]")]
        public List<Topic> GetCourseTopic()
        {
            return _courseService.GetCourseTopic();
        }
        [HttpPut]
        [Route("[action]")]
        public bool UpdateCategory([FromBody] Category category)
        {
            return _courseService.UpdateCategory(category);
        }
        [HttpPut]
        [Route("[action]")]
        public bool UpdateComment([FromBody] Comment comment)
        {
            return _courseService.UpdateComment(comment);
        }
        [HttpPut]
        [Route("[action]")]
        public bool UpdateCourse([FromBody] Course course)
        {
            return _courseService.UpdateCourse(course);
        }
        [HttpPut]
        [Route("[action]")]
        public bool UpdateTopic([FromBody] Topic topic)
        {
            return _courseService.UpdateTopic(topic);
        }
    }
}
