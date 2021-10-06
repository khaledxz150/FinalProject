using LMS.Tahaluf.Core.Data;
using LMS.Tahaluf.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.Tahaluf.Core.Repository
{
    public interface IBookRepository
    {
        public List<Book> GetAllBook();

    }
}
