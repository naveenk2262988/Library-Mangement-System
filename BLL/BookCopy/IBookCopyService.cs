using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BookCopy
{
    
        public interface IBookCopyService
        {
            BookCopy GetBookCopyById(int bookCopyId);
            IEnumerable<BookCopy> GetAllBookCopies();
            void AddBookCopy(BookCopy bookCopy);
            void UpdateBookCopy(BookCopy bookCopy);
            void DeleteBookCopy(int bookCopyId);
        }

}
