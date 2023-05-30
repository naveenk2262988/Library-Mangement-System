using DAL.Models;
using DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repository.Interface;
using DAL.Models.DTO;

namespace DAL.Repository
{
    public class BookRepository : IBook
    {
        private readonly DatabaseContext _context;

        public BookRepository(DatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }

        public Book GetById(Guid guid)
        {
            return _context.Books.Find(guid);
        }

        public int AddBook(BookDTO bookDTO)
        {
            int done;
            var domain = new Book
            {
                Title = bookDTO.Title,
                Author = bookDTO.Author,
                PublicationYear = bookDTO.PublicationYear,
                Publisher = bookDTO.Publisher,
                ISBN = bookDTO.ISBN,
                Genre = bookDTO.Genre,
            };
            _context.Books.Add(domain);
            done = _context.SaveChanges();
            return done;

        }

        public string Update(BookDTO bookDTO)
        {
            string done = "";
            var books = _context.Books.FirstOrDefault(i => i.BookID == bookDTO.BookID);
            if(books != null)
            {
                _context.Books.Update(books);
                _context.SaveChanges();
                done = "Done";
                return done;
            }
            done = "Not Done";
            return done;
            
            
        }


        public void Delete(Book book)
        {
            _context.Books.Remove(book);
            _context.SaveChanges();
        }

        public bool Exist(Guid guid)
        {
            var present = _context.Books.Find(guid);
            if(present != null)
            {
                return true;
            }
            return false;
        }
    }
}
