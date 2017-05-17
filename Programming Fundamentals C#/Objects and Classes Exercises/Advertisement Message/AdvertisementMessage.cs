using System;
using System.Collections.Generic;

namespace Advertisement_Message
{
    public class AdvertisementMessage
    {
        public static void Main()
        {
            var numberOfMessages = int.Parse(Console.ReadLine());

            var phrases = new List<string>() {"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."};
            var events = new List<string>() { "Now I feel good.", "I have succeeded with this product.", "Makes miracles.I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            var authors = new List<string>() { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            var cities = new List<string>() { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            var rng = new Random();

            for (int i = 0; i < numberOfMessages; i++)
            {
                var randomPhrase = rng.Next(0, phrases.Count);
                var phrase = phrases[randomPhrase];

                var randomEvent = rng.Next(0, events.Count);
                var event1 = events[randomEvent];

                var randomAuthor = rng.Next(0, authors.Count);
                var author = authors[randomAuthor];

                var randomCity = rng.Next(0, cities.Count);
                var city = cities[randomCity];

                Console.WriteLine($"{phrase} {event1} {author} - {city}");
            }
        }
    }
}
