using System.Collections.Generic;

namespace Book_Comparator
{
    public class BookComparator : IComparer<Book>
    {
        public int Compare(Book firstBook, Book secondBook)
        {
            return firstBook.Title.CompareTo(secondBook.Title) != 0 ? firstBook.Title.CompareTo(secondBook.Title) : -firstBook.Year.CompareTo(secondBook.Year);
        }
    }
}
