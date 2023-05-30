using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Repository.Interface
{
    public interface IBookCopy
    {
        IEnumerable<BookCopy> GetAll();
        BookCopy GetById(int id);
        void Add(BookCopy bookCopy);
        void Update(BookCopy bookCopy);
        void Delete(BookCopy bookCopy);
    }
}
