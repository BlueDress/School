using System;
using System.Collections.Generic;

namespace Deck_of_Cards
{
    public class Startup
    {
        public static void Main()
        {
            var deckOfCards = new List<Card>();

            foreach (var suit in Enum.GetNames(typeof(CardSuit)))
            {
                foreach (var rank in Enum.GetNames(typeof(CardRank)))
                {
                    var card = new Card(suit, rank);
                    deckOfCards.Add(card);
                }
            }

            foreach (var card in deckOfCards)
            {
                Console.WriteLine(card.ToString());
            }
        }
    }
}
