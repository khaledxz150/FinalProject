using Dapper;
using First.Core.Common;
using LMS.Core.Repository;
using LMS.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infra.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IDbContext _dbContext;
        public EmployeeRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddNewEmployee(Employee employee)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@ssn", employee.NationalSecurutiyNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            queryParameters.Add("@fname", employee.Fname, dbType: DbType.String, direction: ParameterDirection.Input);
            queryParameters.Add("@lname", employee.Lname, dbType: DbType.String, direction: ParameterDirection.Input);
            queryParameters.Add("@email", employee.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            queryParameters.Add("@phone", employee.PhoneNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            queryParameters.Add("@imagepath", employee.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            queryParameters.Add("@role", employee.RoleTypeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            queryParameters.Add("@salary", employee.BasicSalary, dbType: DbType.Double, direction: ParameterDirection.Input);
            //execute proc
            var result = _dbContext.Connection.ExecuteAsync("AddNewEmployee", queryParameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public Employee DeleteEmployee(long employeeId)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@employeeId", employeeId, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("DisActivateEmployee", queryParameters, commandType: CommandType.StoredProcedure);
            return GetEmployee(employeeId);
        }
        public Employee GetEmployee(long employeeId)
        {

            var queryParameters = new DynamicParameters();
            queryParameters.Add("@employeeId", employeeId, dbType: DbType.Int64, direction: ParameterDirection.Input);
            Employee result = _dbContext.Connection.QuerySingle<Employee>("SearchForEmployee", queryParameters, commandType: CommandType.StoredProcedure);
            return result;
        }
        public List<Employee> GetAllEmployess(int queryType)
        {
            var parm = new DynamicParameters();
            parm.Add("@Query_CODE", queryType, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Employee> result = _dbContext.Connection.Query<Employee>("ReturnEmployee", parm, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateEmployee(Employee employee)
        {

            var queryParameters = new DynamicParameters();
            queryParameters.Add("@EmployeeId", employee.EmployeeId, dbType: DbType.Int64, direction: ParameterDirection.Input);
            queryParameters.Add("@ssn", employee.NationalSecurutiyNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            queryParameters.Add("@fname", employee.Fname, dbType: DbType.String, direction: ParameterDirection.Input);
            queryParameters.Add("@lname", employee.Lname, dbType: DbType.String, direction: ParameterDirection.Input);
            queryParameters.Add("@email", employee.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            queryParameters.Add("@phone", employee.PhoneNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            queryParameters.Add("@image", employee.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            queryParameters.Add("@RoleTypeId", employee.RoleTypeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            queryParameters.Add("@salary", employee.BasicSalary, dbType: DbType.Double, direction: ParameterDirection.Input);
            //execute proc
            var result = _dbContext.Connection.ExecuteAsync("UpdateEmployee", queryParameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
