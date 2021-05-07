using my_books.Data.Models;
using my_books.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// The Service class is where your Core Business Logic Goes
// It contains the various Business Use cases that are supported by you App
// Internally each use case needs to access/modify the data along with respecting the business rules
// Externally each of these use cases will be called by the Controller to meet its API Specification

namespace my_books.Data.Services
{
    public class BooksService
    {
        private AppDbContext _context;
        public BooksService(AppDbContext context)
        {
            _context = context;
        }

        public void AddBook(BookViewModel book)
        {
            var _book = new Book()
            {
                Title = book.Title,
                Description = book.Description,
                IsRead = book.IsRead,
                DateRead = book.IsRead ? book.DateRead : null,
                Rate = book.IsRead? book.Rate : null,
                Genre = book.Genre,
                Author = book.Author,
                CoverURL = book.CoverURL,
                DateAdded = DateTime.Now
            };
            _context.Add(_book);
            _context.SaveChanges();
        }

        public List<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }

        public Book GetBookByID(int bookID)
        {
            return _context.Books.FirstOrDefault(n => n.Id == bookID);
        }

        public Book UpdateBookByID(int bookID, BookViewModel book)
        {
            var _book = _context.Books.FirstOrDefault(n => n.Id == bookID);
            if (_book !=null)
            {
                _book.Title = book.Title;
                _book.Description = book.Description;
                _book.IsRead = book.IsRead;
                _book.DateRead = book.IsRead ? book.DateRead : null;
                _book.Rate = book.IsRead ? book.Rate : null;
                _book.Genre = book.Genre;
                _book.Author = book.Author;
                _book.CoverURL = book.CoverURL;
            }

            _context.SaveChanges();

            return _book;
        }

        public void DeleteBookByID(int bookID)
        {
            var _book = _context.Books.FirstOrDefault(n => n.Id == bookID);
            if (_book != null)
            {
                _context.Books.Remove(_book);
                _context.SaveChanges();
            }
        }
    }
}
