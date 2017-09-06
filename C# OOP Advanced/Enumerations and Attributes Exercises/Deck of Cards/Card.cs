using System;

namespace Deck_of_Cards
{
    public class Card
    {
        private CardSuit cardSuit;
        private CardRank cardRank;

        public Card(string cardSuit, string cardRank)
        {
            this.cardSuit = (CardSuit)Enum.Parse(typeof(CardSuit), cardSuit);
            this.cardRank = (CardRank)Enum.Parse(typeof(CardRank), cardRank);
        }

        public override string ToString()
        {
            return $"{this.cardRank} of {this.cardSuit}";
        }
    }
}
