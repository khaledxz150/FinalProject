using Dapper;
using First.Core.Common;
using LMS.Core.DTO;
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
            queryParameters.Add("@salary", employee.BasicSalary, dbType: DbType.Double, direction: ParameterDirection.Input);
            //execute proc
            var result = _dbContext.Connection.ExecuteAsync("InsertEmployee", queryParameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteEmployee(long employeeId)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@employeeId", employeeId, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("DeleteEmployee", queryParameters, commandType: CommandType.StoredProcedure);
            return true;
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
            queryParameters.Add("@active", employee.IsActive, dbType: DbType.Boolean, direction: ParameterDirection.Input);
            queryParameters.Add("@salary", employee.BasicSalary, dbType: DbType.Double, direction: ParameterDirection.Input);
            //execute proc
            var result = _dbContext.Connection.ExecuteAsync("UpdateEmployee", queryParameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        //Role Type

        public bool AddRoleType(RoleType roleType)
        {

            var queryParameters = new DynamicParameters();
            queryParameters.Add("@RoleName",roleType.RoleName,dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("InsertRoleType", queryParameters, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool DeleteRoleType(int roleTypeId)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@RoleId", roleTypeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("DeleteRoleType", queryParameters, commandType: CommandType.StoredProcedure);
            return true;
        }
        public List<RoleType> GetRoleTypes(int queryCode)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@P_CODE", queryCode, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<RoleType> result = _dbContext.Connection.Query<RoleType>("ReturnRoleType", queryParameters, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<EmployeeInfoDTO> ReturnEmployeeInfo(int employeeId)
        {
            var parm = new DynamicParameters();
            parm.Add("@EmployeeId", employeeId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<EmployeeInfoDTO> result = _dbContext.Connection.Query<EmployeeInfoDTO>("ReturnEmployeeInfo", parm, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool ChangeTrainerStatus(long employeeId)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@EmployeeId", employeeId, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("ChangeTrainerStatus", queryParameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
