using LMS.Tahaluf.Core.Data;
using LMS.Tahaluf.Core.Repository;
using LMS.Tahaluf.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.Tahaluf.Infra.Services
{
    public  class TeacherService :ITeacherService
    {
        private readonly ITeacherRepository _repository;
        public TeacherService(ITeacherRepository repos)
        {
            _repository = repos;
        }
        public void UpdateTeacher(Teacher teacher)
        {
            _repository.UpdateTeacher(teacher);
        }
        public List<Teacher> GetAllTeacher()
        {
            return _repository.GetAllTeacher();
        }
        public List<Teacher> GetTeachersByName(String Name)
        {
            return _repository.GetTeachersByName(Name);
        }
        public List<Teacher> GetTeachersByEmail(String mail)
        {
            return _repository.GetTeachersByEmail(mail);
        }
    }

}
