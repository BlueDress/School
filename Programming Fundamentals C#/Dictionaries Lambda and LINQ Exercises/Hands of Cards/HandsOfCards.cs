using System;
using System.Collections.Generic;
using System.Linq;

namespace Hands_of_Cards
{
    public class HandsOfCards
    {
        public static void Main()
        {
            var nameAndCards = new Dictionary<string, string>();
            while (true)
            {
                var input = Console.ReadLine().Split(':').ToList();

                if (input[0] == "JOKER")
                {
                    break;
                }
                else
                {
                    if (!nameAndCards.ContainsKey(input[0]))
                    {
                        nameAndCards[input[0]] = input[1];
                    }
                    else
                    {
                        nameAndCards[input[0]] += input[1];
                    }
                }
            }

            foreach (var item in nameAndCards)
            {
                var cardSequence = item.Value.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();
                var cardPower = 1;
                var cardType = 1;
                var sum = 0;

                foreach (var combination in cardSequence)
                {
                    if (string.Join("", combination.Take(combination.Length - 1)) == "2")
                    {
                        cardPower = 2;
                    }
                    else if (string.Join("", combination.Take(combination.Length - 1)) == "3")
                    {
                        cardPower = 3;
                    }
                    else if (string.Join("", combination.Take(combination.Length - 1)) == "4")
                    {
                        cardPower = 4;
                    }
                    else if (string.Join("", combination.Take(combination.Length - 1)) == "5")
                    {
                        cardPower = 5;
                    }
                    else if (string.Join("", combination.Take(combination.Length - 1)) == "6")
                    {
                        cardPower = 6;
                    }
                    else if (string.Join("", combination.Take(combination.Length - 1)) == "7")
                    {
                        cardPower = 7;
                    }
                    else if (string.Join("", combination.Take(combination.Length - 1)) == "8")
                    {
                        cardPower = 8;
                    }
                    else if (string.Join("", combination.Take(combination.Length - 1)) == "9")
                    {
                        cardPower = 9;
                    }
                    else if (string.Join("", combination.Take(combination.Length - 1)) == "10")
                    {
                        cardPower = 10;
                    }
                    else if (string.Join("", combination.Take(combination.Length - 1)) == "J")
                    {
                        cardPower = 11;
                    }
                    else if (string.Join("", combination.Take(combination.Length - 1)) == "Q")
                    {
                        cardPower = 12;
                    }
                    else if (string.Join("", combination.Take(combination.Length - 1)) == "K")
                    {
                        cardPower = 13;
                    }
                    else if (string.Join("", combination.Take(combination.Length - 1)) == "A")
                    {
                        cardPower = 14;
                    }

                    if (string.Join("", combination.Skip(combination.Length - 1)) == "S")
                    {
                        cardType = 4;
                    }
                    else if (string.Join("", combination.Skip(combination.Length - 1)) == "H")
                    {
                        cardType = 3;
                    }
                    else if (string.Join("", combination.Skip(combination.Length - 1)) == "D")
                    {
                        cardType = 2;
                    }
                    else if (string.Join("", combination.Skip(combination.Length - 1)) == "C")
                    {
                        cardType = 1;
                    }

                    sum += cardType * cardPower;
                }
                Console.WriteLine($"{item.Key}: {sum}");
            }
        }
    }
}
