using Dapper;
using LMS.Tahaluf.Core.Common;
using LMS.Tahaluf.Core.DTO;
using LMS.Tahaluf.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LMS.Tahaluf.Infra.Repository
{
    public class SCTRepository : ISCTRepository
    {
        private readonly IDbContext dBContext;

        public SCTRepository(IDbContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public List<SCT> SCTs()
        {
            IEnumerable<SCT> result = dBContext.Connection.Query<SCT>("STC", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<FUN_ALL_STD> FUN_ALL_STD()
        {
            IEnumerable<FUN_ALL_STD> result = dBContext.Connection.Query<FUN_ALL_STD>("FUN_ALL_STD", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}