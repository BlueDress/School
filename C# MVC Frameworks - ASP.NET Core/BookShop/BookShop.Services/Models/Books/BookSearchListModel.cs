using BookShop.Common.Mapping;
using BookShop.Data.Models;

namespace BookShop.Services.Models.Books
{
    public class BookSearchListModel : IMapFrom<Book>
    {
        public int Id { get; set; }
        
        public string Title { get; set; }
    }
}
