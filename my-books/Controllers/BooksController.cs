using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_books.Data.Services;
using my_books.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private BooksService _booksService;

        public BooksController(BooksService booksService)
        {
            _booksService = booksService;
        }

        [HttpPost]
        public IActionResult AddBook([FromBody] BookViewModel book)
        {
            _booksService.AddBook(book);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAllBooks()
        {
            return Ok(_booksService.GetAllBooks());
        }

        [HttpGet("{bookID}")]
        public IActionResult GetBook(int bookID)
        {
            return Ok(_booksService.GetBookByID(bookID));
        }

        [HttpPut("{bookID}")]
        public IActionResult UpdateBookByID(int bookID,[FromBody]BookViewModel book)
        {
            return Ok(_booksService.UpdateBookByID(bookID,book));
        }

        [HttpDelete("{bookID}")]
        public IActionResult DeleteBookByID(int bookID)
        {
            _booksService.DeleteBookByID(bookID);
            return Ok();
        }   
    }
}
