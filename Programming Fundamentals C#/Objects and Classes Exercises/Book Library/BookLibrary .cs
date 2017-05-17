using System;
using System.Collections.Generic;
using System.Linq;

namespace Book_Library
{
    public class Program
    {
        public static void Main()
        {
            var numberOfBooks = int.Parse(Console.ReadLine());

            var newLibrary = new Library
            {
                Name = "CurrentBooks",
                Books = new List<Book>()
            };

            for (int i = 0; i < numberOfBooks; i++)
            {
                var inputCommands = Console.ReadLine().Split().ToList();
                var author = inputCommands[1];
                var price = decimal.Parse(inputCommands[5]);

                if (!newLibrary.Books.Any(x => x.Author == author))
                {
                    var newBook = new Book
                    {
                        Author = author,
                        Price = price
                    };
                    newLibrary.Books.Add(newBook);
                }
                else
                {
                    var addPrice = newLibrary.Books.First(x => x.Author == author);
                    addPrice.Price += price;
                }
            }

            foreach (var book in newLibrary.Books.OrderByDescending(x => x.Price).ThenBy(x => x.Author))
            {
                Console.WriteLine($"{book.Author} -> {book.Price}");
            }
        }
    }
}
