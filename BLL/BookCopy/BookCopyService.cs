using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BookCopy
{
        public class BookCopyService : IBookCopyService
        {
            private readonly IBookCopyRepository _bookCopyRepository;

            public BookCopyService(IBookCopyRepository bookCopyRepository)
            {
                _bookCopyRepository = bookCopyRepository;
            }

            public BookCopy GetBookCopyById(int bookCopyId)
            {
                return _bookCopyRepository.GetBookCopyById(bookCopyId);
            }

            public IEnumerable<BookCopy> GetAllBookCopies()
            {
                return _bookCopyRepository.GetAllBookCopies();
            }

            public void AddBookCopy(BookCopy bookCopy)
            {
                // Perform any necessary validation or business logic before adding the book copy

                // Call the repository method to add the book copy
                _bookCopyRepository.AddBookCopy(bookCopy);
            }

            public void UpdateBookCopy(BookCopy bookCopy)
            {
                // Perform any necessary validation or business logic before updating the book copy

                // Call the repository method to update the book copy
                _bookCopyRepository.UpdateBookCopy(bookCopy);
            }

            public void DeleteBookCopy(int bookCopyId)
            {
                // Perform any necessary validation or business logic before deleting the book copy

                // Call the repository method to delete the book copy
                _bookCopyRepository.DeleteBookCopy(bookCopyId);
            }
        }
    

}
