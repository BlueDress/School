using BookShop.Api.Infrastructure.Extensions;
using BookShop.Services.Contracts;
using BookShop.Services.Models.Books;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Api.Controllers
{
    public class BooksController : BaseApiController
    {
        private readonly IBooksService bookService;

        public BooksController(IBooksService bookService)
        {
            this.bookService = bookService;
        }

        [HttpGet("{id}")]
        public IActionResult GetBookById(int id)
        {
            var book = this.bookService.GetBookById(id);

            return this.OkOrNotFound(book);
        }

        [HttpGet]
        public IActionResult GetBooksBySearchInput([FromQuery]string search = "")
        {

            var books = this.bookService.GetBooksBySearchInput(search);

            return Ok(books);
        }

        [HttpPost]
        public IActionResult CreateBook([FromBody]CreateBookModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(model);
            }

            this.bookService.CreateBook(model);

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult EditBookById([FromBody]EditBookByIdModel model, int id)
        {
            if (!this.bookService.BookExists(id))
            {
                return BadRequest();
            }

            this.bookService.EditBookById(model, id);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBookById(int id)
        {
            if (!this.bookService.BookExists(id))
            {
                return BadRequest();
            }

            this.bookService.DeleteBookById(id);

            return Ok();
        }
    }
}
