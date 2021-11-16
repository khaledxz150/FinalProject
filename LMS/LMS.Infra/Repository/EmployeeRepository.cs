using Dapper;
using First.Core.Common;
using LMS.Core.Data;
using LMS.Core.DTO;
using LMS.Core.Repository;
using LMS.Data;
using Microsoft.Data.SqlClient;
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

        public async Task<bool> AddNewEmployee(EmployeeInfoDTO employee)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@ssn", employee.NationalSecurutiyNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            queryParameters.Add("@fname", employee.FName, dbType: DbType.String, direction: ParameterDirection.Input);
            queryParameters.Add("@lname", employee.LName, dbType: DbType.String, direction: ParameterDirection.Input);
            queryParameters.Add("@email", employee.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            queryParameters.Add("@phone", employee.PhoneNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            queryParameters.Add("@imagepath", employee.EmployeeImage, dbType: DbType.String, direction: ParameterDirection.Input);
            queryParameters.Add("@salary", employee.BasicSalary, dbType: DbType.Double, direction: ParameterDirection.Input);
            //execute proc
            var result = await _dbContext.Connection.ExecuteAsync("InsertEmployee", queryParameters, commandType: CommandType.StoredProcedure);



            var employeeId = GetAllEmployess(1).OrderByDescending(x => x.EmployeeId).FirstOrDefault().EmployeeId;

            var parameters = new DynamicParameters();
            parameters.Add("@username", employee.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@pass", employee.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@P_EmployeeId", employeeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@P_TraineeId", null, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@P_RoleId", employee.RoleId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result1 = await _dbContext.Connection.ExecuteAsync("InsertLogin", parameters, commandType: CommandType.StoredProcedure);

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
            queryParameters.Add("@RoleName", roleType.RoleName, dbType: DbType.String, direction: ParameterDirection.Input);
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

        public bool DeleteEmployeeFromDatabase(long employeeId)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@employeeId", employeeId, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("DeleteEmployeeFromDatabase", queryParameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Employee> GetAllAttendance(int queryCode)
        {
            throw new NotImplementedException();
        }

        public bool AddAttendanceTrainee(List<Attendance_Tup> att)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("LectureId", typeof(int));
            dt.Columns.Add("IsPresent", typeof(bool));
            dt.Columns.Add("IsActive", typeof(bool));
            dt.Columns.Add("CreationDate", typeof(DateTime));
            dt.Columns.Add("CreatedBy", typeof(long));
            dt.Columns.Add("traineeId", typeof(int));
            for (int i = 0; i < att.Count; i++)
            {
                dt.Rows.Add(att[i].LectureId, att[i].IsPresent, att[i].IsActive, att[i].CreationDate, att[i].CreatedBy, att[i].traineeId);
            }
            using (_dbContext.Connection)
            {
                SqlCommand sql_cmnd = new SqlCommand("AddTraineeAttendance", (SqlConnection)_dbContext.Connection);
                SqlParameter Parameter = new SqlParameter();
                Parameter.ParameterName = "@TraineeList";
                Parameter.SqlDbType = SqlDbType.Structured;
                Parameter.Value = dt;
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                sql_cmnd.Parameters.Add(Parameter);
                sql_cmnd.ExecuteNonQuery();
                //string msg = sql_cmnd.ExecuteScalar().ToString();
            }


            //var parameters = new DynamicParameters();
            //parameters.Add("@TraineeList", att, dbType: DbType.Object, direction: ParameterDirection.Input); ;
            //var result = _dbContext.Connection.ExecuteAsync("AddTraineeAttendance", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool StatusEmployee(int empId)
        {
            throw new NotImplementedException();
        }

        public List<TraineeAttendanceDTO> ReturnTrainneeBySectionId(int sectionId)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@P_SectionId ", sectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<TraineeAttendanceDTO> result = _dbContext.Connection.Query<TraineeAttendanceDTO>("ReturnTraineeBySectionId_Test", queryParameters, commandType: CommandType.StoredProcedure);
            return result.ToList();

        }


    }
}
