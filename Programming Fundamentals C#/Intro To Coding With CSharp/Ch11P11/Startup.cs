using System;
using System.Collections.Generic;

namespace Ch11P11
{
    public class Startup
    {
        public static void Main()
        {
            int numberOfMessages = int.Parse(Console.ReadLine());

            List<string> phrases = new List<string>() { "Продуктът е отличен.", "Това е страхотен продукт.", "Постоянно ползвам този продукт.", "Това е най-добрият продукт от тази категория." };
            List<string> events = new List<string>() { "Вече се чувствам добре.", "Успях да сепроменя.", "Той направи чудо.", "Не мога да повярвам, но вече се чувствам страхотно.", "Опитайте и вие. Аз съм много доволна." };
            List<string> firstNames = new List<string>() { "Диана", "Петя", "Стела", "Елена", "Катя" };
            List<string> lastNames = new List<string>() { "Иванова", "Петрова", "Кирова" };
            List<string> cities = new List<string>() { "София", "Пловдив", "Варна", "Русе", "Бургас" };

            Random rng = new Random();

            for (int i = 0; i < numberOfMessages; i++)
            {
                int randomPhrase = rng.Next(0, phrases.Count);
                string phrase = phrases[randomPhrase];

                int randomEvent = rng.Next(0, events.Count);
                string eventMessage = events[randomEvent];

                int randomFirstName = rng.Next(0, firstNames.Count);
                string firstName = firstNames[randomFirstName];

                int randomLastName = rng.Next(0, lastNames.Count);
                string lastName = lastNames[randomLastName];

                int randomCity = rng.Next(0, cities.Count);
                string city = cities[randomCity];

                Console.WriteLine($"{phrase} {eventMessage} - {firstName} {lastName}, {city}");
            }
        }
    }
}
