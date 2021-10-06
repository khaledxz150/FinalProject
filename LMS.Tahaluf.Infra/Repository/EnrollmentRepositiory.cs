using LMS.Tahaluf.Core.Common;
using LMS.Tahaluf.Core.DTO;
using LMS.Tahaluf.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Dapper;

namespace LMS.Tahaluf.Infra.Repository
{
    public class EnrollmentRepositiory : IEnrollmentRepositiory
    {
        private readonly IDbContext _dbContex;

        public EnrollmentRepositiory(IDbContext dbContext)
        {
            _dbContex = dbContext;  
        }

        public List<Enrollment> getAllEnrolmentsRecord()
        {
            IEnumerable<Enrollment> result = _dbContex.Connection.Query<Enrollment>("GetAllCourse", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

    }
}
