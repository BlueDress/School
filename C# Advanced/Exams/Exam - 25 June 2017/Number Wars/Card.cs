using System;

namespace Number_Wars
{
    public class Card : IComparable<Card>
    {
        private int value;
        private char suffix;

        public Card(int value, char suffix)
        {
            this.value = value;
            this.suffix = suffix;
        }

        public int Value => value;

        public char Suffix => suffix;

        public int CompareTo(Card other)
        {
            if (this.Value > other.Value)
            {
                return 1;
            }
            else if (this.Value < other.Value)
            {
                return -1;
            }
            else
            {
                if (this.Suffix > other.Suffix)
                {
                    return 1;
                }
                else if (this.Suffix < other.Suffix)
                {
                    return -1;
                }
            }

            return 0;
        }
    }
}
