using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp
{
    /// <summary>
    /// Simple blackjack tutorial with no classes but do separate work into methods, user vs computer
    /// Be able to keep score of user and computer, auto-generate (do NOT try hard coding this) a deck of cards, deal cards from a deck, 
    /// track cards that have been removed from deck, determine when the game is over and who won.
    /// Ace = 1 here, not accounting for ace value being 11
    /// Not accounting for computer ability to hit (will implement these in secondary version in Part 2)
    /// </summary>
    public class BlackJackSimpleSln
    {
        public void Run()
        {
            // welcome
            Console.WriteLine("Welcome to blackjack! Would you like to play against the computer?");

            bool isGameOn = true;

            while (isGameOn)
            {
                Console.WriteLine("Dealing cards.");
                var deck = GenerateDeck();

                // set score to 0
                var userScore = 0;
                var compScore = 0;

                // deal initial cards
                userScore += DealCard(deck, true, "User");
                userScore += DealCard(deck, true, "User");
                compScore += DealCard(deck, false, "Comp");
                compScore += DealCard(deck, true, "Comp");

                Console.WriteLine("Do you want to hit?");

                // additional hits
                bool hit = true;
                while (hit)
                {
                    userScore += DealCard(deck, true, "User");

                    if (userScore > 21)
                    {
                        Console.WriteLine("You lose");
                        break;
                    }

                    Console.WriteLine("Do you want to hit again?");
                }

                // final compare
                if (userScore <= 21)
                {
                    if (userScore > compScore) Console.WriteLine("User wins!");
                    else if (userScore < compScore) Console.WriteLine("Computer wins!");
                    else Console.WriteLine("Draw");
                }

                Console.WriteLine("Do you want to play again?");
            }
        }

        private static int DealCard(List<string> deck, bool displayCard, string player)
        {
            Random rand = new Random();

            var cardDrawn = rand.Next(0, deck.Count);

            if (displayCard) 
            {
                Console.WriteLine($"{player} card is: {deck[cardDrawn]}");
            }

            var cardValue = AddCardValueToScore(deck[cardDrawn]);
            deck.RemoveAt(cardDrawn);

            return cardValue;
        }

        public static int AddCardValueToScore(string card)
        {
            if (card.Contains("Ace")) return 1;
            if (card.Contains("2")) return 2;
            if (card.Contains("3")) return 3;
            if (card.Contains("4")) return 4;
            if (card.Contains("5")) return 5;
            if (card.Contains("6")) return 6;
            if (card.Contains("7")) return 7;
            if (card.Contains("8")) return 8;
            if (card.Contains("9")) return 9;
            if (card.Contains("10") || card.Contains("Jack") || card.Contains("Queen") || card.Contains("King")) return 10;

            return 0;
        }

        public static List<string> GenerateDeck()
        {
            List<string> deck = new List<string>();

            string[] cardTypes = new string[] { "Spades", "Hearts", "Diamonds", "Clubs"  };
            string[] cardValues = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            foreach (var cardType in cardTypes)
            {
                foreach (var cardValue in cardValues)
                {
                    var card = cardValue + " of " + cardType;
                    deck.Add(card);
                }
            }

            return deck;
        }
    }
}
