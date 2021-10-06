using LMS.Tahaluf.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.Tahaluf.Core.Repository
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudent();
    }
}
