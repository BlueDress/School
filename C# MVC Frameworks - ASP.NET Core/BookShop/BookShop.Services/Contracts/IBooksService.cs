using BookShop.Services.Models.Books;
using System.Collections.Generic;

namespace BookShop.Services.Contracts
{
    public interface IBooksService
    {
        BookByIdModel GetBookById(int id);

        IEnumerable<BookSearchListModel> GetBooksBySearchInput(string searchedText);

        void CreateBook(CreateBookModel model);

        void EditBookById(EditBookByIdModel model, int id);

        void DeleteBookById(int id);

        bool BookExists(int id);
    }
}
