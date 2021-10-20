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
    public class LevelRepository: ILevelRepository
    {
        private IDbContext dBContext;
        public LevelRepository(IDbContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public bool DeleteLevel(int levelId)
        {
            var parm = new DynamicParameters();
            parm.Add("@LevelId", levelId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("DeleteLevel", parm, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool InsertLevel(Level level)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Name", level.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@CreatedBy", level.CreatedBy, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("InsertLevel", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Level> ReturnLevel(int queryCode)
        {
            var parm = new DynamicParameters();
            parm.Add("@P_CODE", queryCode, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Level> result = dBContext.Connection.Query<Level>("ReturnLevel", parm, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateLevel(Level level)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@LevelId", level.LevelId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Name", level.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@CreatedBy", level.CreatedBy, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("UpdateLevel", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
