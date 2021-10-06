using LMS.Tahaluf.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.Tahaluf.Core.Services
{
    public interface ITeacherService
    {
        public void UpdateTeacher(Teacher teacher);
        public List<Teacher> GetAllTeacher();
        public List<Teacher> GetTeachersByName(String Name);
        public List<Teacher> GetTeachersByEmail(String mail);
    }
}
