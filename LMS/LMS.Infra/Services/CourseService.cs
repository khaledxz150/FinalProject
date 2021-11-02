using LMS.Core.DTO;
using LMS.Core.Repository;
using LMS.Core.Services;
using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infra.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public bool InsertCategory(Category category)
        {
            return _courseRepository.InsertCategory(category);
        }

        public bool InsertComment(Comment comment)
        {
            return _courseRepository.InsertComment(comment);
        }

        public bool InsertCourse(Course course)
        {
            return _courseRepository.InsertCourse(course);
        }

        public bool InsertTopic(Topic topic)
        {
            return _courseRepository.InsertTopic(topic);
        }
        public bool InsertTag(Tag tag)
        {
            return _courseRepository.InsertTag(tag);
        }
        public bool DeleteCategory(int categoryId)
        {
            return _courseRepository.DeleteCategory(categoryId);
        }

        public bool DeleteComment(int commentId)
        {
            return _courseRepository.DeleteComment(commentId);
        }

        public bool DeleteCoupon(int couponId)
        {
            return _courseRepository.DeleteCoupon(couponId);
        }

        public bool DeleteCourse(int courseId)
        {
            return _courseRepository.DeleteCourse(courseId);
        }

        public bool DeleteTag(int tagId)
        {
            return _courseRepository.DeleteTag(tagId);
        }

        public bool DeleteTopic(int topicId)
        {
            return _courseRepository.DeleteTopic(topicId);
        }

        public List<Category> GetAllCategories(int queryCode)
        {
            return _courseRepository.GetAllCategories(queryCode);
        }

        public List<Comment> GetAllCommentForCourse(int queryCode)
        {
            return _courseRepository.GetAllCommentForCourse(queryCode);
        }

        public List<CommentDTO> ReturnAllComments(int courseId, int queryCode)
        {
            return _courseRepository.ReturnAllComments(courseId, queryCode);
        }

        public List<Course> GetAllCourse(int queryCode)
        {
            return _courseRepository.GetAllCourse(queryCode);
        }

        public List<Tag> GetAllTags()
        {
            return _courseRepository.GetAllTags();
        }

        public List<Topic> GetCourseTopic()
        {
            return _courseRepository.GetCourseTopic();
        }
        public List<Coupon> GetAllCoupons(int queryCody)
        {
            return _courseRepository.GetAllCoupons(queryCody);
        }

        //ReturnAllCoupon
        public List<CouponDTO> ReturnAllCoupon(int queryCode)
        {
            return _courseRepository.ReturnAllCoupon(queryCode);
        }


        public bool InsertCoupon(Coupon coupon)
        {
            return _courseRepository.InsertCoupon(coupon);
        }


        public bool InsertCourseRate(CourseRating courseRating)
        {
            return _courseRepository.InsertCourseRate(courseRating);
        }

        public bool UpdateCategory(Category category)
        {
            return _courseRepository.UpdateCategory(category);
        }

        public bool UpdateComment(Comment comment)
        {
            return _courseRepository.UpdateComment(comment);
        }

        public bool UpdateCoupon(Coupon coupon)
        {
            return _courseRepository.UpdateCoupon(coupon);
        }

        public bool UpdateCourse(Course course)
        {
            return _courseRepository.UpdateCourse(course);
        }

        public bool UpdateCourseRating(CourseRating courseRating)
        {
            return _courseRepository.UpdateCourseRating(courseRating);
        }

        public bool UpdateTopic(Topic topic)
        {
            return _courseRepository.UpdateTopic(topic);
        }

        public bool InsertType(Data.Type type)
        {
            return _courseRepository.InsertType(type);
        }
        public bool DeleteType(int typeId)
        {
            return _courseRepository.DeleteType(typeId);
        }

        public List<Data.Type> GetAllType(int queryCode)
        {
            return _courseRepository.GetAllType();
        }

        public List<Data.Type> GetAllType()
        {
           return _courseRepository.GetAllType();   
        }

        public List<CourseRatingDTO> ReturnAllCourseRating(int sectionId)
        {
            return _courseRepository.ReturnAllCourseRating(sectionId);
        }

        public List<CourseDTO> ReturnAllCourses(int queryCode)
        {
            return _courseRepository.ReturnAllCourses(queryCode);
        }

        public bool DeleteLevel(int levelId)
        {
            return _courseRepository.DeleteLevel(levelId);
        }

        public bool InsertLevel(Level level)
        {
            return _courseRepository.InsertLevel(level);
        }

        public List<Level> ReturnLevel(int queryCode)
        {
            return _courseRepository.ReturnLevel(queryCode);

        }

        public bool UpdateLevel(Level level)
        {
            return _courseRepository.UpdateLevel(level);
        }
    }
}
