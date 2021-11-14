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
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        //**********************************************<-- Insert -->*******************************************
        [HttpPost]
        [Route("[action]")]

        public bool InsertCategory([FromBody] Category category)
        {
            return _courseService.InsertCategory(category);
        }
        [HttpPost]
        [Route("[action]")]
        public bool InsertComment([FromBody] Comment comment)
        {
            return _courseService.InsertComment(comment);
        }
        [HttpPost]
        [Route("[action]")]
        public bool InsertCourse([FromBody] Course course)
        {
            return _courseService.InsertCourse(course);
        }
        [HttpPost]
        [Route("[action]")]
        public bool InsertTopic([FromBody] Topic topic)
        {
            return _courseService.InsertTopic(topic);
        }
        [HttpPost]
        [Route("[action]")]
        public bool InsertType([FromBody] Data.Type type)
        {
            return _courseService.InsertType(type);
        }

        [HttpPost]
        [Route("[action]")]
        public bool InsertCoupon([FromBody] Coupon coupon)
        {
            return _courseService.InsertCoupon(coupon);
        }

        [HttpPost]
        [Route("[action]")]
        public bool InsertCourseRate([FromBody] CourseRating courseRating)
        {
            return _courseService.InsertCourseRate(courseRating);
        }
        [HttpPost]
        [Route("[action]")]
        public bool InsertTag([FromBody] Tag tag)
        {
            return _courseService.InsertTag (tag);
        }
       //**********************************************<-- Delete -->*******************************************
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
        [Route("[action]/{couponId}")]
        public bool DeleteCoupon(int couponId)
        {
            return _courseService.DeleteCoupon(couponId);
        }

        [HttpPut]
        [Route("[action]/{typeId}")]
        public bool DeleteType(int typeId)
        {
            return _courseService.DeleteType(typeId);   
        }
        //**********************************************<-- Get/Return All -->*******************************************
        [HttpPost]
        [Route("[action]/{queryCode}")]
        public List<Category> GetAllCategories(int queryCode)
        {
            return _courseService.GetAllCategories(queryCode);
        }
        [HttpPost]
        [Route("[action]/{queryCode}")]
        public List<Comment> GetAllCommentForCourse(int queryCode)
        {
            return _courseService.GetAllCommentForCourse(queryCode);
        }
        [HttpPost]
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
        [HttpPost]
        [Route("[action]/{courseId}")]
        public List<Topic> GetCourseTopic(int courseId)
        {
            return _courseService.GetCourseTopic(courseId);
        }
        [HttpGet]
        [Route("[action]")]
        public List<Data.Type> GetAllType()
        {
            return _courseService.GetAllType();
        }
        //ReturnAllCoupon
        [HttpPost]
        [Route("[action]/{queryCode}")]
        public List<CouponDTO> ReturnAllCoupon(int queryCode)
        {
            return _courseService.ReturnAllCoupon(queryCode);
        }

        [HttpPost]
        [Route("[action]/{queryCode}")]
        public List<Coupon> GetAllCoupons(int queryCode)
        {
            return _courseService.GetAllCoupons(queryCode);
        }
        //**********************************************<-- Update -->*******************************************
        [HttpPut]
        [Route("[action]")]
        public bool UpdateCategory([FromBody] Category category)
        {
            return _courseService.UpdateCategory(category);
        }

        [HttpPut]
        [Route("[action]")]
        public bool UpdateCoupon([FromBody] Coupon coupon)
        {
            return _courseService.UpdateCoupon(coupon);
        }
        [HttpPut]
        [Route("[action]")]
        public bool UpdateCourseRating([FromBody] CourseRating courseRating)
        {
            return _courseService.UpdateCourseRating(courseRating);
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
        //**********************************************<-- DTO -->*******************************************

        //ReturnAllCourseRating
        [HttpPost]
        [Route("[action]/{sectionId}")]
        public List<CourseRatingDTO> ReturnAllCourseRating(int sectionId)
        {
            return _courseService.ReturnAllCourseRating(sectionId);
        }
        [HttpPost]
        [Route("[action]/{courseId}")]
        public List<CourseRating> GetCourseRatings(int courseId)
        {
            return _courseService.GetCourseRatings(courseId);
        }
        //ReturnAllCourses

        [HttpPost]
        [Route("[action]/{queryCode}")]
        public List<CourseDTO> ReturnAllCourses(int queryCode)
        {
            return _courseService.ReturnAllCourses(queryCode);
        }

        [HttpPost]
        [Route("[action]")]
        public List<CommentDTO> ReturnAllComments([FromQuery] int courseId, [FromQuery] int querycode)
        {
            return _courseService.ReturnAllComments(courseId, querycode);
        }


        [HttpPost]
        [Route("[action]/{queryCode}")]
        public List<Level> ReturnLevel(int queryCode)
        {
            return _courseService.ReturnLevel(queryCode);
        }

        [HttpPost]
        [Route("[action]")]
        public bool InsertLevel([FromBody] Level level)
        {
            return _courseService.InsertLevel(level);
        }

        [HttpPut]
        [Route("[action]")]
        public bool UpdateLevel([FromBody] Level level)
        {
            return _courseService.UpdateLevel(level);
        }

        [HttpPut]
        [Route("[action]/{levelId}")]
        public bool DeleteLevel(int levelId)
        {
            return _courseService.DeleteLevel(levelId);
        }



    }
}



