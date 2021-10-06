using LMS.Tahaluf.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.Tahaluf.Core.Services
{
    public interface ICourseServices
    {
        public List<Course> GetChepasetCourse();
        public List<Course> GetCourseByStartDate(DateTime startdate);
        public List<Course> GetCourseByPrice(double price);

        public bool DeleteCourse(int id);
        public void UpdateCourse(Course course);
        public List<Course> GetByCourseName(String courseName);

        public List<Course> GetByCourseName(Course course);
        public bool CreateCourse(Course course);
        public List<Course> GetAllCourse();
    }
}
