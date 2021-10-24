using Dapper;
using First.Core.Common;
using LMS.Core.Repository;
using LMS.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infra.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly IDbContext _dbContext;
        public CourseRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddNewCategory(Category category)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@Name", category.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            queryParameters.Add("@employeeId", category.CreatedBy, dbType: DbType.Int64, direction: ParameterDirection.Input);
            //execute proc
            var result = _dbContext.Connection.ExecuteAsync("AddNewCategoty", queryParameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool AddNewComment(Comment comment)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@Description", comment.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            queryParameters.Add("@SectionId", comment.SectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            queryParameters.Add("@CourseId", comment.CourseId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            queryParameters.Add("@traineeId", comment.CreatedBy, dbType: DbType.Int32, direction: ParameterDirection.Input);
            //execute proc
            var result = _dbContext.Connection.ExecuteAsync("AddNewComment", queryParameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool AddNewCourse(Course course)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@CourseName", course.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            queryParameters.Add("@CourseDescription", course.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            queryParameters.Add("@passMark", course.PassMark, dbType: DbType.Int32, direction: ParameterDirection.Input);
            queryParameters.Add("@CoursePrice", course.CoursePrice, dbType: DbType.Double, direction: ParameterDirection.Input);
            queryParameters.Add("@TypeId", course.TypeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            queryParameters.Add("@Image", course.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            queryParameters.Add("@PreviewVideoUrl", course.PreviewVideoUrl, dbType: DbType.String, direction: ParameterDirection.Input);
            queryParameters.Add("@LevelId", course.LevelId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            queryParameters.Add("@CategoryId", course.CategoryId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            queryParameters.Add("@TagId", course.TagId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            queryParameters.Add("@employeeId", course.CreatedBy, dbType: DbType.Int64, direction: ParameterDirection.Input);
            //execute proc
            var result = _dbContext.Connection.ExecuteAsync("AddNewCourse", queryParameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool AddNewTopic(Topic topic)
        {

            var queryParameters = new DynamicParameters();
            queryParameters.Add("@P_TopicName", topic.TopicName, dbType: DbType.String, direction: ParameterDirection.Input);
            queryParameters.Add("@P_CourseId", topic.CourseId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            queryParameters.Add("@P_Description", topic.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            queryParameters.Add("@P_CreatedBy", topic.CreatedBy, dbType: DbType.Int64, direction: ParameterDirection.Input);
            //execute proc
            var result = _dbContext.Connection.ExecuteAsync("AddTopic", queryParameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteCategory(int categoryId)
        {
            var queryParameters = new DynamicParameters();

            queryParameters.Add("@recordId", categoryId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            //execute proc
            var result = _dbContext.Connection.ExecuteAsync("DisActivateCategory", queryParameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteComment(int commentId)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@recordId", commentId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            //execute proc
            var result = _dbContext.Connection.ExecuteAsync("DisActivateComment", queryParameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteCourse(int courseId)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@recordId", courseId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            //execute proc
            var result = _dbContext.Connection.ExecuteAsync("DisActivateCourse", queryParameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteTag(int tagId)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@P_TagId", tagId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            //execute proc
            var result = _dbContext.Connection.ExecuteAsync("DeleteTag", queryParameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteTopic(int topicId)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@P_Id", topicId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            //execute proc
            var result = _dbContext.Connection.ExecuteAsync("DeleteTopic", queryParameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Category> GetAllCategories(int queryCode)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@Query_CODE", queryCode, dbType: DbType.Int32, direction: ParameterDirection.Input);
            //execute proc
            IEnumerable<Category> result = _dbContext.Connection.Query<Category>("ReturnCategory", queryParameters, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Comment> GetAllCommentForCourse(int queryCode)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@Query_CODE", queryCode, dbType: DbType.Int32, direction: ParameterDirection.Input);
            //execute proc
            IEnumerable<Comment> result = _dbContext.Connection.Query<Comment>("ReturnComment", queryParameters, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Course> GetAllCourse(int queryCode)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@Query_CODE", queryCode, dbType: DbType.Int32, direction: ParameterDirection.Input);
            //execute proc
            IEnumerable<Course> result = _dbContext.Connection.Query<Course>("ReturnCourse", queryParameters, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Tag> GetAllTags()
        {
            IEnumerable<Tag> result = _dbContext.Connection.Query<Tag>("ReturnAllTag", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Topic> GetCourseTopic()
        {
            IEnumerable<Topic> result = _dbContext.Connection.Query<Topic>("ReturnAllTopic", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateCategory(Category category)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@CategoryId", category.CategoryId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            queryParameters.Add("@Name", category.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            queryParameters.Add("@IsActive", category.IsActive, dbType: DbType.Boolean, direction: ParameterDirection.Input);
            queryParameters.Add("@CREATIONDATE", category.CreationDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            queryParameters.Add("@employeeId", category.CreatedBy, dbType: DbType.Int64, direction: ParameterDirection.Input);

            //execute proc
            var result = _dbContext.Connection.ExecuteAsync("UpdateCategory", queryParameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateComment(Comment comment)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@sectionId", comment.SectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            queryParameters.Add("@courseId", comment.CourseId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            queryParameters.Add("@CommentId", comment.CommentId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            queryParameters.Add("@Description", comment.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            //execute proc
            var result = _dbContext.Connection.ExecuteAsync("UpdateComment", queryParameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateCourse(Course course)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@CourseId", course.CourseId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            queryParameters.Add("@name", course.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            queryParameters.Add("@description", course.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            queryParameters.Add("@pass", course.PassMark, dbType: DbType.Int32, direction: ParameterDirection.Input);
            queryParameters.Add("@price", course.CoursePrice, dbType: DbType.Double, direction: ParameterDirection.Input);
            queryParameters.Add("@typeId", course.TypeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            queryParameters.Add("@tagId", course.TagId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            queryParameters.Add("@levelId", course.LevelId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            queryParameters.Add("@categoryId", course.CategoryId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            queryParameters.Add("@image", course.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            queryParameters.Add("@video", course.PreviewVideoUrl, dbType: DbType.String, direction: ParameterDirection.Input);

            //execute proc
            var result = _dbContext.Connection.ExecuteAsync("UpdateCourse", queryParameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateTopic(Topic topic)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@P_Id", topic.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            queryParameters.Add("@P_TopicName", topic.TopicName, dbType: DbType.String, direction: ParameterDirection.Input);
            queryParameters.Add("@P_CourseId", topic.CourseId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            queryParameters.Add("@P_Description", topic.Description, dbType: DbType.String, direction: ParameterDirection.Input);

            //execute proc
            var result = _dbContext.Connection.ExecuteAsync("UpdateTopic", queryParameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
