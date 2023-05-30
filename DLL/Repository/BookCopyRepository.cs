//using DAL.Models;
//using DAL.Data;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using DAL.Repository.Interface;

//namespace DAL.Repository
//{
//    public class BookCopyRepository : IBookCopy
//    {
//        private readonly DatabaseContext _context;

//        public BookCopyRepository(DatabaseContext context)
//        {
//            _context = context;
//        }

//        public IEnumerable<BookCopy> GetAll()
//        {
//            return _context.BookCopies.ToList();
//        }

//        public BookCopy GetById(int id)
//        {
//            return _context.BookCopies.Find(id);
//        }

//        public void Add(BookCopy bookCopy)
//        {
//            _context.BookCopies.Add(bookCopy);
//            _context.SaveChanges();
//        }

//        public void Update(BookCopy bookCopy)
//        {
//            _context.BookCopies.Update(bookCopy);
//            _context.SaveChanges();
//        }

//        public void Delete(BookCopy bookCopy)
//        {
//            _context.BookCopies.Remove(bookCopy);
//            _context.SaveChanges();
//        }
//    }
//}
