using DAL.Models;
using DAL.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Repository.Interface
{
    public interface IBook
    {
        IEnumerable<Book> GetAllBooks();
        Book GetById(Guid guid);
        int AddBook(BookDTO bookDTO);
        bool Exist(Guid guid);
        string Update(BookDTO bookDTO);
        void Delete(Book book);
    }
}

