using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Book
{
 
        public interface IBookService
        {
            Book GetBookById(int bookId);
            IEnumerable<Book> GetAllBooks();
            void AddBook(Book book);
            void UpdateBook(Book book);
            void DeleteBook(int bookId);
            void IssueBook(int bookId, int userId);
            void ReturnBook(int bookId, int userId);
        }
 

}
