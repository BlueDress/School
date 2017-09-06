using System;
using System.Collections.Generic;
using System.Linq;

namespace Card_Game
{
    public class Startup
    {
        public static void Main()
        {
            var deckOfCards = GetDeckOfCards();

            var playerOne = Console.ReadLine();
            var playerTwo = Console.ReadLine();

            var playerOneHand = new List<Card>();
            var playerTwoHand = new List<Card>();

            DealCards(deckOfCards, playerOneHand, playerTwoHand);
            ComparingThePlayersHands(playerOneHand, playerTwoHand, playerOne, playerTwo);

        }

        private static void ComparingThePlayersHands(List<Card> playerOneHand, List<Card> playerTwoHand, string playerOne, string playerTwo)
        {
            var playerOneStrongestCard = playerOneHand.OrderByDescending(card => card.CalculatePower()).First();
            
            var playerTwoStrongestCard = playerTwoHand.OrderByDescending(card => card.CalculatePower()).First();

            var winningMessage = playerOneStrongestCard.CompareTo(playerTwoStrongestCard) >= 0 ? $"{playerOne} wins with {playerOneStrongestCard.CardName}." : $"{playerTwo} wins with {playerTwoStrongestCard.CardName}.";
            Console.WriteLine(winningMessage);
        }

        private static void DealCards(List<Card> deckOfCards, List<Card> playerOneHand, List<Card> playerTwoHand)
        {
            while (true)
            {
                if (playerOneHand.Count == 5 && playerTwoHand.Count == 5)
                {
                    break;
                }

                var cardName = Console.ReadLine();

                if (deckOfCards.Any(card => card.CardName.Equals(cardName)))
                {
                    if (playerOneHand.Any(card => card.CardName.Equals(cardName)) || playerTwoHand.Any(card => card.CardName.Equals(cardName)))
                    {
                        Console.WriteLine("Card is not in the deck.");
                    }
                    else
                    {
                        var currentCard = deckOfCards.Find(card => card.CardName.Equals(cardName));

                        if (playerOneHand.Count < 5)
                        {
                            playerOneHand.Add(currentCard);
                        }
                        else
                        {
                            playerTwoHand.Add(currentCard);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No such card exists.");
                }
            }
        }

        private static List<Card> GetDeckOfCards()
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

            return deckOfCards;
        }
    }
}
