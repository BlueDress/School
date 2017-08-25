using System.Collections;
using System.Collections.Generic;

namespace Book_Comparator
{
    public class Library : IEnumerable<Book>
    {
        public SortedSet<Book> books;

        public Library(params Book[] books)
        {
            this.books = new SortedSet<Book>(new BookComparator());
            for (int i = 0; i < books.Length; i++)
            {
                this.books.Add(books[i]);
            }
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly List<Book> books;
            private int currentIndex;

            public LibraryIterator(IEnumerable<Book> books)
            {
                this.Reset();
                this.books = new List<Book>(books);
            }

            public Book Current
            {
                get
                {
                    return this.books[this.currentIndex];
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return this.Current;
                }
            }

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                return ++this.currentIndex < this.books.Count;
            }

            public void Reset()
            {
                this.currentIndex = -1;
            }
        }
    }
}
