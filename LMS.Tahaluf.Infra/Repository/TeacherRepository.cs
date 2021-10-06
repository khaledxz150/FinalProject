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
    public class TeacherRepository: ITeacherRepository
    {
        private readonly IDbContext dBContext;

        public TeacherRepository(IDbContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public List<Teacher> GetAllTeacher()
        {
            IEnumerable<Teacher> result = dBContext.Connection.Query<Teacher>("GetAllTeacher", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public void UpdateTeacher(Teacher teacher)
        {
            var p = new DynamicParameters();
            p.Add("@teacherId", teacher.ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@teacherName", teacher.TeacherName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@teacherEmail", teacher.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@teacherSalary", teacher.Salary, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@teacherPhone", teacher.PhoneNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@teacherloginId", teacher.LoginId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("updateTeacher", p, commandType: CommandType.StoredProcedure);
        }
        public List<Teacher> GetTeachersByName(String Name)
        {
            var p = new DynamicParameters();
            p.Add("@teacherName", Name, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<Teacher> result = dBContext.Connection.Query<Teacher>("GetByTeacherName", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Teacher>GetTeachersByEmail(String mail)
        {
            var p = new DynamicParameters();
            p.Add("@teacherEmail", mail, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<Teacher> result = dBContext.Connection.Query<Teacher>("FindTeacherByEmail", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
