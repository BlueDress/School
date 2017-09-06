using System;

namespace Card_Power
{
    public class Startup
    {
        public static void Main()
        {
            var cardRank = Console.ReadLine();
            var cardSuit = Console.ReadLine();

            var card = new Card(cardSuit, cardRank);

            Console.WriteLine(card.ToString());
        }
    }
}
