using System;

namespace Card_Suit
{
    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Card Suits:");

            var cardSuits = Enum.GetValues(typeof(CardSuit));

            foreach (var cardSuit in cardSuits)
            {
                Console.WriteLine($"Ordinal value: {(int)cardSuit}; Name value: {cardSuit}");
            }
        }
    }
}
