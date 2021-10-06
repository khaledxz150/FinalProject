using LMS.Tahaluf.Core.Data;
using LMS.Tahaluf.Core.Repository;
using LMS.Tahaluf.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.Tahaluf.Infra.Services
{
    public class CourseService: ICourseServices
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public bool CreateCourse(Course course)
        {
            return _courseRepository.CreateCourse(course);
        }

        public bool DeleteCourse(int id)
        {
            return _courseRepository.DeleteCourse(id);
        }

        public List<Course> GetAllCourse()
        {
           return _courseRepository.GetAllCourse();
        }

        public List<Course> GetByCourseName(string courseName)
        {
           return  _courseRepository.GetByCourseName(courseName);
        }

        public List<Course> GetByCourseName(Course course)
        {
            return _courseRepository.GetByCourseName(course);
        }

        public List<Course> GetChepasetCourse()
        {
            return _courseRepository.GetChepasetCourse();
        }

        public List<Course> GetCourseByPrice(double price)
        {
            return _courseRepository.GetCourseByPrice(price);
        }

        public List<Course> GetCourseByStartDate(DateTime startdate)
        {
            return _courseRepository.GetCourseByStartDate(startdate);
        }

        public void UpdateCourse(Course course)
        {
            _courseRepository.UpdateCourse   (course);
        }
    }
}
