using Bookstore.Models;
using Bookstore.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Controllers
{
    public class HomeController : Controller
    {
        private readonly BookRepository _bookRepository = null;

        public HomeController()
        {
            _bookRepository = new BookRepository();
        }

        public ViewResult Index()
        {
            return View();
        }
        public List<BookModel> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }

        public BookModel GetBookById(int bookid)
        {
           return _bookRepository.GetBookById(bookid);
        }

        public List<BookModel> SearchBook(string bookName, string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName);
        }








    }
}
