using System.Collections.Generic;
using System.Linq;

namespace Ch14P20
{
    public class Library
    {
        private string name;
        private List<Book> books;

        public Library(string name, List<Book> books)
        {
            this.name = name;
            this.books = books;
        }

        public string Name { get => name; set => name = value; }
        public List<Book> Books { get => books; set => books = value; }

        public void AddBook(Book book)
        {
            this.books.Add(book);
        }

        public Book GetBookByAuthor(string author)
        {
            return this.books.FirstOrDefault(b => b.Author.Equals(author));
        }

        public string GetBookInfo(string title)
        {
            Book book = this.books.FirstOrDefault(b => b.Title.Equals(title));

            return book.ToString();
        }

        public void DeleteBook(Book book)
        {
            this.books.Remove(book);
        }
    }
}
