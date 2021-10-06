using LMS.Tahaluf.Core.Data;
using LMS.Tahaluf.Core.DTO;
using LMS.Tahaluf.Core.Repository;
using LMS.Tahaluf.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.Tahaluf.Infra.Services
{
   public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        
        public List<Course> GetAllCourse()
        {
            return _courseRepository.GetAllCourse();
        }

        public bool CreateCourse(Course course)
        {
            return _courseRepository.CreateCourse(course);
        }

        public List<Course> GetByCourseName(String courseName)
        {
            return _courseRepository.GetByCourseName(courseName);
        }

        public List<Course> GetByCourseName(Course course)
        {
            return _courseRepository.GetByCourseName(course);
        }


        public void UpdateCourse(Course course)
        {
            _courseRepository.UpdateCourse(course);
        }
        public bool DeleteCourse(int id)
        {
            return _courseRepository.DeleteCourse(id);
        }

        public List<Course> GetByCoursePrice(double price)
        {
            return _courseRepository.GetByCoursePrice(price);
        }

        public List<Course> GetCourseBetweenDate(SearchBetweenates dates)
        {
            return _courseRepository.GetCourseBetweenDate(dates);
        }
    }
}
