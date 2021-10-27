using LMS.Core.DTO;
using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Repository
{
    public interface ICourseRepository
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
        // Tag
        public List<Tag> GetAllTags();
        public bool DeleteTag(int tagId);
        // Topic
        public List<Topic> GetCourseTopic();
        public bool InsertTopic(Topic topic);
        public bool UpdateTopic(Topic topic);
        public bool DeleteTopic(int topicId);
        // Category 
        public List<Category> GetAllCategories(int queryCode);
        public bool InsertCategory(Category category);
        public bool UpdateCategory(Category category);
        public bool DeleteCategory(int categoryId);

        // Coupon 
        public bool InsertCoupon(Coupon coupon);
        public bool UpdateCoupon(Coupon coupon);
        public bool DeleteCoupon(int couponId);
        //public List<Coupon>ReuturnCoupons(int queryCode); --> back for it 
        //public List<Coupon> ReturnCouponByCourseId(int courseId); --> backforit 
        //public List<Coupon> GetSpecifin(int ) back for it --> Jasser Alshaer


        //Course Rating 
        public bool InsertCourseRate(CourseRating courseRating);
        public bool UpdateCourseRating(CourseRating courseRating);

        // Type 
        public bool AddType(Data.Type type);
        public bool DeleteType(int typeId);

        public List<Data.Type> GetAllType();



        //ReturnAllCourseRating
        public List<CourseRatingDTO> ReturnAllCourseRating(int sectionId);



        //ReturnCourses
        public List<CourseDTO> ReturnAllCourses(int queryCode);

    }
}
