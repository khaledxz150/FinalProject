using LMS.Tahaluf.Core.Data;
using LMS.Tahaluf.Core.Repository;
using LMS.Tahaluf.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.Tahaluf.Infra.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookrepos;

        public BookService(IBookRepository book)
        {
            _bookrepos=book;
        }
        public List<Book> GetAllBooks()
        {
            return _bookrepos.GetAllBooks();
        }
        public List<Book> GetBookByName(String bookName)
        {
            return _bookrepos.GetBookByName(bookName);
        }

        public List<Book> GetBookByPrice(double price)
        {
            return _bookrepos.GetBookByPrice(price);
        }

    }
}
