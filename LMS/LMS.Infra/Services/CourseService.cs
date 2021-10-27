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

        public bool AddNewCategory(Category category)
        {
            return _courseRepository.AddNewCategory(category);
        }

        public bool AddNewComment(Comment comment)
        {
            return _courseRepository.AddNewComment(comment);
        }

        public bool AddNewCourse(Course course)
        {
            return _courseRepository.AddNewCourse(course);
        }

        public bool AddNewTopic(Topic topic)
        {
            return _courseRepository.AddNewTopic(topic);
        }

        public bool DeleteCategory(int categoryId)
        {
            return _courseRepository.DeleteCategory(categoryId);
        }

        public bool DeleteComment(int commentId)
        {
            return _courseRepository.DeleteComment(commentId);
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

        public bool UpdateCategory(Category category)
        {
            return _courseRepository.UpdateCategory(category);
        }

        public bool UpdateComment(Comment comment)
        {
            return _courseRepository.UpdateComment(comment);
        }

        public bool UpdateCourse(Course course)
        {
            return _courseRepository.UpdateCourse(course);
        }

        public bool UpdateTopic(Topic topic)
        {
            return _courseRepository.UpdateTopic(topic);
        }
    }
}
