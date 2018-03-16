using AutoMapper.QueryableExtensions;
using BookShop.Data;
using BookShop.Data.Models;
using BookShop.Services.Contracts;
using BookShop.Services.Models.Authors;
using System.Linq;
using System.Collections.Generic;

namespace BookShop.Services.Implementations
{
    public class AuthorsService : IAuthorsService
    {
        private readonly BookShopDbContext db;

        public AuthorsService(BookShopDbContext db)
        {
            this.db = db;
        }

        public AuthorListModel GetAuthorById(int id)
        {
            return this.db.Authors.Where(a => a.Id == id).ProjectTo<AuthorListModel>().FirstOrDefault();
        }

        public void CreateAuthor(CreateAuthorModel model)
        {
            var author = new Author()
            {
                FirstName = model.FirstName,
                LastName = model.LastName
            };

            this.db.Authors.Add(author);
            this.db.SaveChanges();
        }

        public IEnumerable<BooksByAuthorModel> GetBooksByAuthor(int id)
        {
            return this.db.Books.Where(b => b.AuthorId == id).ProjectTo<BooksByAuthorModel>().ToList();
        }
    }
}
