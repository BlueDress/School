using System;
using System.Collections.Generic;

namespace Comparable_Book
{
    public class Book : IComparable<Book>
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

        public int CompareTo(Book otherBook)
        {
            //if (this.Year.CompareTo(other.Year) != 0)
            //{
            //    return this.Year.CompareTo(other.Year);
            //}
            //else
            //{
            //    return this.Title.CompareTo(other.Title);
            //}

            return this.Year.CompareTo(otherBook.Year) != 0 ? this.Year.CompareTo(otherBook.Year) : this.Title.CompareTo(otherBook.Title);
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }
    }
}
