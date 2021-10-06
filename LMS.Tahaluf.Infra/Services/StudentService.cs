using LMS.Tahaluf.Core.Data;
using LMS.Tahaluf.Core.Repository;
using LMS.Tahaluf.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.Tahaluf.Infra.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repository;

        public StudentService(IStudentRepository repos)
        {
            _repository = repos;
        }
        public List<Student> GetAllStudent()
        {
            return _repository.GetAllStudent();
        }
    }
}
