using LMS.Tahaluf.Core.Data;
using LMS.Tahaluf.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace LMS.Tahaluf.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _service;

        public BookController(IBookService service)
        {
            _service = service;  
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Teacher>), StatusCodes.Status200OK)]
        public List<Book> GetAllBooks()
        {
           return _service.GetAllBooks();
        }
        [HttpGet]
        [Route ("GetByName/{bookName}")]
        [ProducesResponseType(typeof(List<Teacher>), StatusCodes.Status200OK)]
        public List<Book> GetBookByName(String bookName)
            {
            return  _service.GetBookByName(bookName);
            }
        [HttpGet]
        [Route("GetByPrice/{price}")]
        [ProducesResponseType(typeof(List<Teacher>), StatusCodes.Status200OK)]
        public List<Book> GetBookByPrice(double price)
            {
            return _service.GetBookByPrice(price);  
            }
    }
}
