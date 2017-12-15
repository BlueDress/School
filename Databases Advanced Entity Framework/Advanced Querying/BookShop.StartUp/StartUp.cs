namespace BookShop
{
    using BookShop.Data;
    using BookShop.Initializer;
    using System;
    using System.Linq;
    using System.Text;
    using BookShop.Models;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            //using (var db = new BookShopContext())
            //{
            //    DbInitializer.ResetDatabase(db);
            //}

            var db = new BookShopContext();

            //var command = Console.ReadLine().ToLower();
            //Console.WriteLine(GetBooksByAgeRestriction(db, command)); 

            //Console.WriteLine(GetGoldenBooks(db));

            //Console.WriteLine(GetBooksByPrice(db));

            //var year = int.Parse(Console.ReadLine());
            //Console.WriteLine(GetBooksNotRealeasedIn(db, year));

            //var categories = Console.ReadLine();
            //Console.WriteLine(GetBooksByCategory(db, categories));

            //var date = Console.ReadLine();
            //Console.WriteLine(GetBooksReleasedBefore(db, date));

            //var nameEndsWith = Console.ReadLine();
            //Console.WriteLine(GetAuthorNamesEndingIn(db, nameEndsWith));

            //var titleContains = Console.ReadLine();
            //Console.WriteLine(GetBookTitlesContaining(db, titleContains));

            //var lastNameStartsWith = Console.ReadLine();
            //Console.WriteLine(GetBooksByAuthor(db, lastNameStartsWith));

            //var lengthCheck = int.Parse(Console.ReadLine());
            //Console.WriteLine(CountBooks(db, lengthCheck));

            //Console.WriteLine(CountCopiesByAuthor(db));

            //Console.WriteLine(GetTotalProfitByCategory(db));

            //Console.WriteLine(GetMostRecentBooks(db));

            //IncreasePrices(db);

            //Console.WriteLine($"{RemoveBooks(db)} books were deleted");
        }

        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            var sb = new StringBuilder();

            using (context)
            {
                context.Books.Where(b => b.AgeRestriction.ToString().ToLower().Equals(command)).Select(b => b.Title).OrderBy(t => t).ToList().ForEach(b => sb.AppendLine(b));
            }

            return sb.ToString();
        }

        public static string GetGoldenBooks(BookShopContext context)
        {
            var sb = new StringBuilder();

            using (context)
            {
                context.Books.Where(b => b.Copies < 5000 && b.EditionType.ToString().Equals("Gold")).OrderBy(b => b.BookId).Select(b => b.Title).ToList().ForEach(b => sb.AppendLine(b));
            }

            return sb.ToString();
        }

        public static string GetBooksByPrice(BookShopContext context)
        {
            var sb = new StringBuilder();

            using (context)
            {
                context.Books.Where(b => b.Price > 40).Select(b => new
                {
                    Title = b.Title,
                    Price = b.Price
                }).OrderByDescending(b => b.Price).ToList().ForEach(b => sb.AppendLine($"{b.Title} - ${b.Price}"));
            }

            return sb.ToString();
        }

        public static string GetBooksNotRealeasedIn(BookShopContext context, int year)
        {
            var sb = new StringBuilder();

            using (context)
            {
                context.Books.Where(b => b.ReleaseDate.Value.Year != year).OrderBy(b => b.BookId).Select(b => b.Title).ToList().ForEach(t => sb.AppendLine(t));
            }

            return sb.ToString();
        }

        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            var sb = new StringBuilder();

            using (context)
            {
                var categories = input.Split();

                context.Books.Where(b => b.BookCategories.Any(c => categories.Contains(c.Category.Name))).Select(b => b.Title).OrderBy(t => t).ToList().ForEach(t => sb.AppendLine(t));
            }

            return sb.ToString();
        }

        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            var sb = new StringBuilder();

            using (context)
            {
                var dateAsDateTime = DateTime.Parse(date);

                context.Books.Where(b => DateTime.Compare(b.ReleaseDate.Value, dateAsDateTime) < 0).OrderByDescending(b => b.ReleaseDate).Select(b => new
                {
                    Title = b.Title,
                    EditionType = b.EditionType,
                    Price = b.Price
                }).ToList().ForEach(b => sb.AppendLine($"{b.Title} - {b.EditionType} - ${b.Price}"));
            }

            return sb.ToString();
        }

        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var sb = new StringBuilder();

            using (context)
            {
                context.Authors.Where(a => a.FirstName.EndsWith(input)).Select(a => new
                {
                    FullName = $"{a.FirstName} {a.LastName}"
                }).OrderBy(a => a.FullName).ToList().ForEach(a => sb.AppendLine(a.FullName));
            }

            return sb.ToString();
        }

        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            var sb = new StringBuilder();

            using (context)
            {
                context.Books.Where(b => b.Title.ToLower().Contains(input.ToLower())).Select(b => b.Title).OrderBy(t => t).ToList().ForEach(t => sb.AppendLine(t));
            }

            return sb.ToString();
        }

        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var sb = new StringBuilder();

            using (context)
            {
                context.Books.Where(b => b.Author.LastName.ToLower().StartsWith(input.ToLower())).OrderBy(b => b.BookId).Select(b => new
                {
                    Title = b.Title,
                    AuthorFullName = $"{b.Author.FirstName} {b.Author.LastName}"
                }).ToList().ForEach(b => sb.AppendLine($"{b.Title} ({b.AuthorFullName})"));
            }

            return sb.ToString();
        }

        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            return context.Books.Where(b => b.Title.Length > lengthCheck).Count();
        }

        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var sb = new StringBuilder();

            using (context)
            {
                context.Authors.Select(a => new
                {
                    FullName = $"{a.FirstName} {a.LastName}",

                    NumberOfCopies = a.Books.Sum(b => b.Copies)
                }).OrderByDescending(a => a.NumberOfCopies).ToList().ForEach(a => sb.AppendLine($"{a.FullName} - {a.NumberOfCopies}"));
            }

            return sb.ToString();
        }

        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var sb = new StringBuilder();

            using (context)
            {
                context.Categories.Select(c => new
                {
                    Name = c.Name,
                    Profit = c.CategoryBooks.Sum(bc => bc.Book.Price * bc.Book.Copies)
                }).OrderByDescending(c => c.Profit).ThenBy(c => c.Name).ToList().ForEach(c => sb.AppendLine($"{c.Name} ${c.Profit}"));
            }

            return sb.ToString();
        }

        public static string GetMostRecentBooks(BookShopContext context)
        {
            var sb = new StringBuilder();

            using (context)
            {
                context.Categories.Select(c => new
                {
                    Name = c.Name,
                    Books = c.CategoryBooks.Select(b => new
                    {
                        b.Book.Title,
                        b.Book.ReleaseDate
                    }).ToList()
                }).OrderBy(c => c.Books.Count).ThenBy(c => c.Name).ToList().ForEach((c) =>
                {
                    sb.AppendLine($"--{c.Name}");
                    foreach (var book in c.Books.OrderByDescending(b => b.ReleaseDate).Take(3))
                    {
                        sb.AppendLine($"{book.Title} ({book.ReleaseDate.Value.Year})");
                    }
                });
            }

            return sb.ToString();
        }

        public static void IncreasePrices(BookShopContext context)
        {
            using (context)
            {
                context.Books.Where(b => b.ReleaseDate.Value.Year < 2010).ToList().ForEach(b => b.Price += 5);
                context.SaveChanges();
            }
        }

        public static int RemoveBooks(BookShopContext context)
        {
            using (context)
            {
                var booksToRemove = context.Books.Where(b => b.Copies < 4200).ToList();

                context.Books.RemoveRange(booksToRemove);
                context.SaveChanges();

                return booksToRemove.Count();
            }
        }
    }
}
