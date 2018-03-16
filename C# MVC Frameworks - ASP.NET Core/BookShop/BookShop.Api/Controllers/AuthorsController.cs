using BookShop.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

using BookShop.Api.Infrastructure.Extensions;
using BookShop.Services.Models.Authors;

namespace BookShop.Api.Controllers
{
    public class AuthorsController : BaseApiController
    {
        private readonly IAuthorsService authorsService;

        public AuthorsController(IAuthorsService authorsService)
        {
            this.authorsService = authorsService;
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthor(int id)
        {
            var author = this.authorsService.GetAuthorById(id);

            return this.OkOrNotFound(author);
        }

        [HttpGet("{id}/books")]
        public IActionResult GetBooksByAuthorId(int id)
        {
            var books = this.authorsService.GetBooksByAuthor(id);

            return Ok(books);
        }

        [HttpPost]
        public IActionResult CreateAuthor([FromBody]CreateAuthorModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(model);
            }

            this.authorsService.CreateAuthor(model);

            return Ok();
        }
    }
}
