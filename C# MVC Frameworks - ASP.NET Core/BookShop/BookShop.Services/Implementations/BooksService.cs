using AutoMapper.QueryableExtensions;
using BookShop.Data;
using BookShop.Services.Contracts;
using BookShop.Services.Models.Books;
using System.Linq;
using System.Collections.Generic;
using BookShop.Data.Models;

namespace BookShop.Services.Implementations
{
    public class BooksService : IBooksService
    {
        private readonly BookShopDbContext db;

        public BooksService(BookShopDbContext db)
        {
            this.db = db;
        }

        public BookByIdModel GetBookById(int id)
        {
            return this.db.Books.Where(b => b.Id == id).ProjectTo<BookByIdModel>().FirstOrDefault();
        }

        public IEnumerable<BookSearchListModel> GetBooksBySearchInput(string searchedText)
        {
            return this.db.Books.Where(b => b.Title.ToLower().Contains(searchedText.ToLower())).ProjectTo<BookSearchListModel>().OrderBy(b => b.Title).Take(10).ToList();
        }

        public void CreateBook(CreateBookModel model)
        {
            var book = new Book
            {
                Title = model.Title,
                Description = model.Description,
                Price = model.Price,
                Copies = model.Copies,
                Edition = model.Edition,
                AgeRestriction = model.AgeRestriction,
                ReleaseDate = model.ReleaseDate,
                AuthorId = model.AuthorId
            };

            //this.db.Categories.Where(c => model.Categories.Contains(c.Name)).Select(c => c.Id).ToList().ForEach(c => book.Categories.ToList().Add(new CategoryBook { CategoryId = c }));

            var categoryIds = this.db.Categories.Where(c => model.Categories.Contains(c.Name)).Select(c => c.Id).ToList();

            categoryIds.ForEach(id => book.Categories.ToList().Add(new CategoryBook { CategoryId = id }));

            this.db.Books.Add(book);
            this.db.SaveChanges();
        }

        public void EditBookById(EditBookByIdModel model, int id)
        {
            var book = this.db.Books.First(b => b.Id == id);

            book.Title = model.Title;
            book.Description = model.Description;
            book.Price = model.Price;
            book.Copies = model.Copies;
            book.AgeRestriction = model.AgeRestriction;
            book.Edition = model.Edition;
            book.ReleaseDate = model.ReleaseDate;
            book.AuthorId = model.AuthorId;

            this.db.SaveChanges();
        }

        public void DeleteBookById(int id)
        {
            var book = this.db.Books.First(b => b.Id == id);

            this.db.Books.Remove(book);
            this.db.SaveChanges();
        }

        public bool BookExists(int id)
        {
            return this.db.Books.Any(b => b.Id == id);
        }
    }
}
