using Bookstore.Models;
using System.Collections.Generic;
using System.Linq;

namespace Bookstore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();

        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(X => X.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(X=>X.Title.Contains(title) || X.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id = 1, Title="MVC",Author="Nitish"},
                new BookModel(){Id = 2, Title="C#", Author="Kudvenkat"},
                new BookModel(){Id=3, Title="Python", Author ="Navin Reddy"},
                new BookModel(){Id = 4,Title="JS",Author ="Akshay Saini"}
            };
        }
    }
}
