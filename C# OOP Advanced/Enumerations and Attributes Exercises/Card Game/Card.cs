using System;

namespace Card_Game
{
    public class Card : IComparable<Card>
    {
        private CardSuit cardSuit;
        private CardRank cardRank;

        public Card(string cardSuit, string cardRank)
        {
            this.cardSuit = (CardSuit)Enum.Parse(typeof(CardSuit), cardSuit);
            this.cardRank = (CardRank)Enum.Parse(typeof(CardRank), cardRank);
        }

        public int CalculatePower()
        {
            return (int)this.cardSuit + (int)this.cardRank;
        }

        public string CardName
        {
            get { return $"{this.cardRank} of {this.cardSuit}"; }
        }

        public override string ToString()
        {
            return this.CardName;
        }

        public int CompareTo(Card other)
        {
            return this.CalculatePower().CompareTo(other.CalculatePower());
        }
    }
}
