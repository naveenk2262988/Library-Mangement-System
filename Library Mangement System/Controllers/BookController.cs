using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library_Mangement_System.Controllers
{
        [Route("api/books")]
        [ApiController]
        public class BookController : ControllerBase
        {
            private readonly IBookService _bookService;

            public BookController(IBookService bookService)
            {
                _bookService = bookService;
            }

            [HttpGet]
            public IActionResult GetBooks()
            {
                var books = _bookService.GetAllBooks();
                return Ok(books);
            }

            [HttpGet("{id}")]
            public IActionResult GetBook(int id)
            {
                var book = _bookService.GetBookById(id);
                if (book == null)
                    return NotFound();

                return Ok(book);
            }

            [HttpPost]
            public IActionResult AddBook(BookModel bookModel)
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var addedBook = _bookService.AddBook(bookModel);
                return CreatedAtAction(nameof(GetBook), new { id = addedBook.Id }, addedBook);
            }

            [HttpPut("{id}")]
            public IActionResult UpdateBook(int id, BookModel bookModel)
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                if (!_bookService.BookExists(id))
                    return NotFound();

                _bookService.UpdateBook(id, bookModel);
                return NoContent();
            }

            [HttpDelete("{id}")]
            public IActionResult DeleteBook(int id)
            {
                if (!_bookService.BookExists(id))
                    return NotFound();

                _bookService.DeleteBook(id);
                return NoContent();
            }
        }
    }

}
