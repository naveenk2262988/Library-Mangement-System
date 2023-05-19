using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library_Mangement_System.Controllers
{
        [Route("api/bookcopies")]
        [ApiController]
        public class BookCopyController : ControllerBase
        {
            private readonly IBookCopyService _bookCopyService;

            public BookCopyController(IBookCopyService bookCopyService)
            {
                _bookCopyService = bookCopyService;
            }

            [HttpGet("{id}")]
            public IActionResult GetBookCopy(int id)
            {
                var bookCopy = _bookCopyService.GetBookCopyById(id);
                if (bookCopy == null)
                    return NotFound();

                return Ok(bookCopy);
            }

            [HttpPost]
            public IActionResult AddBookCopy(BookCopyModel bookCopyModel)
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var addedBookCopy = _bookCopyService.AddBookCopy(bookCopyModel);
                return CreatedAtAction(nameof(GetBookCopy), new { id = addedBookCopy.Id }, addedBookCopy);
            }

            [HttpPut("{id}")]
            public IActionResult UpdateBookCopy(int id, BookCopyModel bookCopyModel)
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var updatedBookCopy = _bookCopyService.UpdateBookCopy(id, bookCopyModel);
                if (updatedBookCopy == null)
                    return NotFound();

                return Ok(updatedBookCopy);
            }

            [HttpDelete("{id}")]
            public IActionResult DeleteBookCopy(int id)
            {
                var deletedBookCopy = _bookCopyService.DeleteBookCopy(id);
                if (deletedBookCopy == null)
                    return NotFound();

                return Ok(deletedBookCopy);
            }
        }
    

}
