using System;

namespace Card_Rank
{
    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Card Ranks:");

            var cardRanks = Enum.GetValues(typeof(CardRanks));

            foreach (var cardRank in cardRanks)
            {
                Console.WriteLine($"Ordinal value: {(int)cardRank}; Name value: {cardRank}");
            }
        }
    }
}
