using Books_RestApi.DTOs;
using Books_RestApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Books_RestApi.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BooksController : ControllerBase
    {
        private static List<Book> books = new List<Book>
        {
            new Book
            {
                Id = 1,
                Title = "C# Basics",
                Author = "Mani"
            }
        };

        // GET ALL
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(books);
        }

        // GET BY ID
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var book = books.FirstOrDefault(x => x.Id == id);

            if (book == null)
            {
                return NotFound("Book not found");
            }

            return Ok(book);
        }

        // CREATE
        [HttpPost]
        public IActionResult Create(CreateBookDto dto)
        {
            var book = new Book
            {
                Id = books.Max(x => x.Id) + 1,
                Title = dto.Title,
                Author = dto.Author
            };

            books.Add(book);

            return CreatedAtAction(
                nameof(GetById),
                new { id = book.Id },
                book
            );
        }

        // UPDATE
        [HttpPut("{id}")]
        public IActionResult Update(int id, UpdateBookDto dto)
        {
            var book = books.FirstOrDefault(x => x.Id == id);

            if (book == null)
            {
                return NotFound("Book not found");
            }

            book.Title = dto.Title;
            book.Author = dto.Author;

            return Ok(book);
        }

        // DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var book = books.FirstOrDefault(x => x.Id == id);

            if (book == null)
            {
                return NotFound("Book not found");
            }

            books.Remove(book);

            return NoContent();
        }
    }
}
