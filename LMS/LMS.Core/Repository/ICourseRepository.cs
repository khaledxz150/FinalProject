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
        public List<Course> GetAllCourse(int queryCode);
        public bool AddNewCourse(Course course);
        public bool UpdateCourse(Course course);
        public bool DeleteCourse(int courseId);

        public List<Comment> GetAllCommentForCourse(int queryCode);

        public bool AddNewComment(Comment comment);

        public bool UpdateComment(Comment comment);
        public bool DeleteComment(int commentId);
        public List<Tag> GetAllTags();
        public bool DeleteTag(int tagId);
        public List<Topic> GetCourseTopic();
        public bool AddNewTopic(Topic topic);
        public bool UpdateTopic(Topic topic);
        public bool DeleteTopic(int topicId);

        public List<Category> GetAllCategories(int queryCode);
        public bool AddNewCategory(Category category);
        public bool UpdateCategory(Category category);
        public bool DeleteCategory(int categoryId);


    }
}
