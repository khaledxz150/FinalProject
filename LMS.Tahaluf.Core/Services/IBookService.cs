using LMS.Tahaluf.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.Tahaluf.Core.Services
{
   public interface IBookService
    {
        public List<Book> GetAllBook();
    }
}
