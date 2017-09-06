using System;

namespace Card_CompareTo__
{
    public class Startup
    {
        public static void Main()
        {
            var firstCardRank = Console.ReadLine();
            var firstCardSuit = Console.ReadLine();

            var firstCard = new Card(firstCardSuit, firstCardRank);

            var secondCardRank = Console.ReadLine();
            var secondCardSuit = Console.ReadLine();

            var secondCard = new Card(secondCardSuit, secondCardRank);

            var greaterCard = firstCard.CompareTo(secondCard) >= 0 ? firstCard : secondCard;

            Console.WriteLine(greaterCard.ToString());
        }
    }
}
