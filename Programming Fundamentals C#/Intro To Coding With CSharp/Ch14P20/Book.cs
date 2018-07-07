namespace Ch14P20
{
    public class Book
    {
        private string title;
        private string author;
        private string publisher;
        private int yearPublished;
        private string isbn;
        
        public Book(string title, string author, string publisher, int yearPublished, string isbn)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.yearPublished = yearPublished;
            this.isbn = isbn;
        }

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public int YearPublished { get => yearPublished; set => yearPublished = value; }
        public string Isbn { get => isbn; set => isbn = value; }

        public override string ToString()
        {
            return $"{title} by {author} --- {publisher} {yearPublished} {isbn}";
        }
    }
}
