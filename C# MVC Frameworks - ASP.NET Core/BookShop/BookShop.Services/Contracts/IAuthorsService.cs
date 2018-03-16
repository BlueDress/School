using BookShop.Data.Models;
using BookShop.Services.Models.Authors;
using System.Collections.Generic;

namespace BookShop.Services.Contracts
{
    public interface IAuthorsService
    {
        AuthorListModel GetAuthorById(int id);

        void CreateAuthor(CreateAuthorModel model);

        IEnumerable<BooksByAuthorModel> GetBooksByAuthor(int id);
    }
}
