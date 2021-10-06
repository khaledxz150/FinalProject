using LMS.Tahaluf.Core.Data;
using LMS.Tahaluf.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.Tahaluf.Core.Services
{
   public interface ICourseService
    {
        public List<Course> GetAllCourse();
        public bool CreateCourse(Course course);
        public void UpdateCourse(Course course);
        public List<Course> GetByCourseName(String courseName);
        public List<Course> GetByCourseName(Course course);

        public bool DeleteCourse(int id);
        public List<Course> GetByCoursePrice(double price);
        public List<Course> GetCourseBetweenDate(SearchBetweenates dates);


    }
}
