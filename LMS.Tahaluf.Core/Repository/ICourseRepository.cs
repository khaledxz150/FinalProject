using LMS.Tahaluf.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.Tahaluf.Core.Repository
{
   public interface ICourseRepository
    {
        public bool CreateCourse(Course course);
        List<Course> GetAllCourse();
        public bool DeleteCourse(int id);
        void UpdateCourse(Course course);
        public List<Course> GetByCourseName(Course course);

        public List<Course> GetByCourseName(String courseName);
        public List<Course> GetCourseByPrice(double price);
        public List<Course> GetCourseByStartDate(DateTime startdate);
        public List<Course> GetChepasetCourse();



    }
}
