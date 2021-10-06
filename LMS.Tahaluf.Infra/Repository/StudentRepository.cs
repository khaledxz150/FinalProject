using Dapper;
using LMS.Tahaluf.Core.Common;
using LMS.Tahaluf.Core.Data;
using LMS.Tahaluf.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LMS.Tahaluf.Infra.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly IDbContext _dBContext;

        public StudentRepository(IDbContext dbContext)
        {
            _dBContext=dbContext;
        }

        public List<Student> GetAllStudent()
        {
            IEnumerable<Student> result = _dBContext.Connection.Query<Student>("GetAllStudents", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
