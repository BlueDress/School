using System;
using System.Collections.Generic;
using System.Linq;

namespace Number_Wars
{
    public class Startup
    {
        public static void Main()
        {
            var firstPlayerCards = Console.ReadLine().Split();
            var secondPlayerCards = Console.ReadLine().Split();

            var firstPlayerDeck = new Queue<Card>();
            var secondPlayerDeck = new Queue<Card>();

            for (int i = 0; i < firstPlayerCards.Length; i++)
            {
                var cardValue = int.Parse(firstPlayerCards[i].Substring(0, firstPlayerCards[i].Length - 1));
                var cardSuffix = firstPlayerCards[i][firstPlayerCards[i].Length - 1];

                var card = new Card(cardValue, cardSuffix);
                firstPlayerDeck.Enqueue(card);
            }

            for (int i = 0; i < secondPlayerCards.Length; i++)
            {
                var cardValue = int.Parse(secondPlayerCards[i].Substring(0, secondPlayerCards[i].Length - 1));
                var cardSuffix = secondPlayerCards[i][secondPlayerCards[i].Length - 1];

                var card = new Card(cardValue, cardSuffix);
                secondPlayerDeck.Enqueue(card);
            }

            for (int i = 1; i <= 1_000_000; i++)
            {
                var firstPlayerCard = firstPlayerDeck.Dequeue();

                var secondPlayerCard = secondPlayerDeck.Dequeue();

                if (firstPlayerCard.Value > secondPlayerCard.Value)
                {
                    firstPlayerDeck.Enqueue(firstPlayerCard);
                    firstPlayerDeck.Enqueue(secondPlayerCard);
                }
                else if (firstPlayerCard.Value < secondPlayerCard.Value)
                {
                    secondPlayerDeck.Enqueue(secondPlayerCard);
                    secondPlayerDeck.Enqueue(firstPlayerCard);
                }
                else
                {
                    var cardsOnTheField = new List<Card>
                    {
                        firstPlayerCard,
                        secondPlayerCard
                    };

                    var firstPlayerThreeCardsSuffixSum = 0;
                    var secondPlayerThreeCardsSuffixSum = 0;

                    while (true)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (firstPlayerDeck.Count > 0)
                            {
                                var firstPlayerNextCard = firstPlayerDeck.Dequeue();
                                firstPlayerThreeCardsSuffixSum += firstPlayerNextCard.Suffix;
                                cardsOnTheField.Add(firstPlayerNextCard);
                            }

                            if (secondPlayerDeck.Count > 0)
                            {
                                var secondPlayerNextCard = secondPlayerDeck.Dequeue();
                                secondPlayerThreeCardsSuffixSum += secondPlayerNextCard.Suffix;
                                cardsOnTheField.Add(secondPlayerNextCard);
                            }
                        }

                        if (firstPlayerThreeCardsSuffixSum > secondPlayerThreeCardsSuffixSum)
                        {
                            foreach (var card in cardsOnTheField.OrderByDescending(c => c))
                            {
                                firstPlayerDeck.Enqueue(card);
                            }

                            break;
                        }
                        else if (firstPlayerThreeCardsSuffixSum < secondPlayerThreeCardsSuffixSum)
                        {
                            foreach (var card in cardsOnTheField.OrderByDescending(c => c))
                            {
                                secondPlayerDeck.Enqueue(card);
                            }

                            break;
                        }
                        else if (firstPlayerDeck.Count == 0 && secondPlayerDeck.Count == 0)
                        {
                            Console.WriteLine($"Draw after {i} turns");
                            return;
                        }
                    }
                }


                if (firstPlayerDeck.Count == 0)
                {
                    Console.WriteLine($"Second player wins after {i} turns");
                    return;
                }

                if (secondPlayerDeck.Count == 0)
                {
                    Console.WriteLine($"First player wins after {i} turns");
                    return;
                }
            }

            if (firstPlayerDeck.Count > secondPlayerDeck.Count)
            {
                Console.WriteLine($"First player wins after 1000000 turns");
            }
            else if (firstPlayerDeck.Count < secondPlayerDeck.Count)
            {
                Console.WriteLine($"Second player wins after 1000000 turns");
            }
            else
            {
                Console.WriteLine($"Draw after 1000000 turns");
            }
        }
    }
}
