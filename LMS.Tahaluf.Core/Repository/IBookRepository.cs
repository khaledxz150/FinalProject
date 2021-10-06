using LMS.Tahaluf.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.Tahaluf.Core.Repository
{
   public interface IBookRepository
    {
        public List<Book> GetAllBooks();
        public List<Book> GetBookByName(String bookName);

        public List<Book> GetBookByPrice(double price);
    }
}
