﻿using System;

namespace Card_Power
{
    public class Card
    {
        private string suit;
        private string rank;

        public Card(string suit, string rank)
        {
            this.suit = suit;
            this.rank = rank;
        }

        private int CalculatePower()
        {
            CardSuit suitPower;
            Enum.TryParse<CardSuit>(this.suit, out suitPower);

            CardRanks rankPower;
            Enum.TryParse<CardRanks>(this.rank, out rankPower);

            return (int)suitPower + (int)rankPower;
        }

        public override string ToString()
        {
            return $"Card name: {this.rank} of {this.suit}; Card power: {this.CalculatePower()}";
        }
    }
}
