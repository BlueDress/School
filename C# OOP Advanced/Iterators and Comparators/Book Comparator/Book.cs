using System.Collections.Generic;

namespace Book_Comparator
{
    public class Book
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public IReadOnlyList<string> Authors { get; set; }

        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = authors;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }
    }
}
