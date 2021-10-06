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

        public List<Book> GetAllBooks()
        {
            IEnumerable<Book> result = dBContext.Connection.Query<Book>("GetAllBook", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Book> GetBookByName(String bookName)
        {
            var p = new DynamicParameters();
            p.Add("@bookName", bookName, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<Book> result = dBContext.Connection.Query<Book>("getBookByName", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
           
        }

        public List<Book> GetBookByPrice(double price)
        {
            var p = new DynamicParameters();
            p.Add("@bookPrice", price, dbType: DbType.Double, direction: ParameterDirection.Input);
            IEnumerable<Book> result = dBContext.Connection.Query<Book>("getBookByPrice", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
