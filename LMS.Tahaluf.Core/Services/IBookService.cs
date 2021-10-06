using LMS.Tahaluf.Core.Data;
using LMS.Tahaluf.Core.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.Tahaluf.Core.Services
{
    public interface IBookService
    {

        public List<Book> GetAllBooks();
        public List<Book> GetBookByName(String bookName);

        public List<Book> GetBookByPrice(double price);

    }
}
