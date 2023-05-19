using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Book
{
        public class BookService : IBookService
        {
            private readonly IBookRepository _bookRepository;

            public BookService(IBookRepository bookRepository)
            {
                _bookRepository = bookRepository;
            }

            public Book GetBookById(int bookId)
            {
                return _bookRepository.GetBookById(bookId);
            }

            public IEnumerable<Book> GetAllBooks()
            {
                return _bookRepository.GetAllBooks();
            }

            public void AddBook(Book book)
            {
                // Perform any necessary validation or business logic before adding the book

                // Call the repository method to add the book
                _bookRepository.AddBook(book);
            }

            public void UpdateBook(Book book)
            {
                // Perform any necessary validation or business logic before updating the book

                // Call the repository method to update the book
                _bookRepository.UpdateBook(book);
            }

            public void DeleteBook(int bookId)
            {
                // Perform any necessary validation or business logic before deleting the book

                // Call the repository method to delete the book
                _bookRepository.DeleteBook(bookId);
            }

            public void IssueBook(int bookId, int userId)
            {
                // Perform any necessary validation or business logic before issuing the book

                // Call the repository method to issue the book
                _bookRepository.IssueBook(bookId, userId);
            }

            public void ReturnBook(int bookId, int userId)
            {
                // Perform any necessary validation or business logic before returning the book

                // Call the repository method to return the book
                _bookRepository.ReturnBook(bookId, userId);
            }
        }
    

}
