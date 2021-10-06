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
   public class BookRepository : IBookRepository
    {
        private readonly IDbContext dBContext;

        public BookRepository(IDbContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public List<Book> GetAllBook()
        {
            IEnumerable<Book> result = dBContext.Connection.Query<Book>("GetAllBook", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
