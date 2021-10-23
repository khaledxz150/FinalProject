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
    public class UserRepository : IUserRepository
    {
        private IDbContext dBContext;
        public UserRepository(IDbContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public bool Register(Login login)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@username", login.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@pass", login.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@P_TraineeId", login.TraineeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@P_EmployeeId", login.EmployeeId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("AddLogin", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteLogin(int loginId)
        {
            var parm = new DynamicParameters();
            parm.Add("@LoginId", loginId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("DeleteLogin", parm, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Login> ReturnLogin()
        {
            IEnumerable<Login> result = dBContext.Connection.Query<Login>("ReturnAllLoginISActive", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Login Authentiaction(Login login)
        {
            var parm = new DynamicParameters();
            parm.Add("@username", login.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            parm.Add("@pass", login.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dBContext.Connection.Query<Login>("LoginElerning", parm, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        //public bool UpdateLogin(Login login)
        //{
        //    var parameters = new DynamicParameters();
        //    parameters.Add("@username", login.Username, dbType: DbType.String, direction: ParameterDirection.Input);
        //    parameters.Add("@pass", login.Password, dbType: DbType.String, direction: ParameterDirection.Input);
        //    parameters.Add("@P_TraineeId", login.TraineeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
        //    parameters.Add("@P_EmployeeId", login.EmployeeId, dbType: DbType.Int32, direction: ParameterDirection.Input);

        //    var result = dBContext.Connection.ExecuteAsync("AddLogin", parameters, commandType: CommandType.StoredProcedure);
        //    return true;
        //}
    }

}
