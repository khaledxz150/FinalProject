using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Services
{
    public interface ICourseService
    {
        //Course
        public List<Course> GetAllCourse(int queryCode);
        public bool InsertCourse(Course course);
        public bool UpdateCourse(Course course);
        public bool DeleteCourse(int courseId);
        //Comment
        public List<Comment> GetAllCommentForCourse(int queryCode);

        public bool InsertComment(Comment comment);

        public bool UpdateComment(Comment comment);
        public bool DeleteComment(int commentId);
        //Topic
        public List<Tag> GetAllTags();
        public bool DeleteTag(int tagId);
        //Topic
        public List<Topic> GetCourseTopic();
        public bool InsertTopic(Topic topic);
        public bool UpdateTopic(Topic topic);
        public bool DeleteTopic(int topicId);
        //Category
        public List<Category> GetAllCategories(int queryCode);
        public bool InsertCategory(Category category);
        public bool UpdateCategory(Category category);
        public bool DeleteCategory(int categoryId);
        //Coupon 
        public bool InsertCoupon(Coupon coupon);
        public bool UpdateCoupon(Coupon coupon);
        public bool DeleteCoupon(int couponId);
        //Course Rating 
        public bool InsertCourseRate(CourseRating courseRating);
        public bool UpdateCourseRating(CourseRating courseRating);
<<<<<<< Updated upstream
=======

        //Type 
        public bool AddType(Data.Type type);
        public bool DeleteType(int typeId);

        public List<Data.Type> GetAllType();
>>>>>>> Stashed changes
    }
}
