using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Book_Library_Modification
{
    public class BookLibraryModification
    {
        public static void Main()
        {
            var numberOfBooks = int.Parse(Console.ReadLine());

            var newLibrary = new Library
            {
                Books = new List<Book>(),
            };

            for (int i = 0; i < numberOfBooks; i++)
            {
                var inputCommands = Console.ReadLine().Split().ToList();
                var title = inputCommands[0];
                var commandDate = inputCommands[3];
                var releaseDate = DateTime.ParseExact(commandDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);

                var newBook = new Book
                {
                    Title = title,
                    ReleaseDate = releaseDate
                };

                newLibrary.Books.Add(newBook);
            }

            var inputDate = Console.ReadLine();
            var startDate = DateTime.ParseExact(inputDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (var book in newLibrary.Books.OrderBy(x => x.ReleaseDate).ThenBy(x => x.Title))
            {
                if (book.ReleaseDate >= startDate)
                {
                    var tempDate = book.ReleaseDate.ToString("dd.MM.yyyy");
                    Console.WriteLine($"{book.Title} -> {tempDate}");
                }
            }
        }
    }
}
