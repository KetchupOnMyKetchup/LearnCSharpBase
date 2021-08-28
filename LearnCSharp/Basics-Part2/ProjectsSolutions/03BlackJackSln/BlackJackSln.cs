using System;

namespace LearnCSharp.Basics_Part2.Projects.BlackJack
{
    /// <summary>
    /// OOP (Object Oriented Programming) Blackjack game:
    /// Recreate the Blackjack game but refactor it so you have a Card, Deck, and Hand class.
    /// Make sure each class handles methods related to it...
    /// For example a Deck should take in Cards and you should be able to Generate a Deck within the Deck class.
    /// </summary>
    public class BlackJackSln
    {
        public void Run()
        {
            // Create new deck
            DeckSln deck = new DeckSln();

            // Shuffle new deck
            deck.Shuffle();

            // Deal initial 4 cards
            HandSln userHand = new HandSln();
            userHand.AddCard(deck.DealTopCard(), true, "User");
            userHand.AddCard(deck.DealTopCard(), true, "User");

            Console.WriteLine($"User total hand value is: {userHand.TotalValue}");

            HandSln compHand = new HandSln();
            compHand.AddCard(deck.DealTopCard(), false, "Computer");
            compHand.AddCard(deck.DealTopCard(), true, "Computer");

            // Ask user to hit
            Console.WriteLine("Do you want to hit?");
            while (true)
            {
                var userResponse = Console.ReadLine().ToLower();
                if (userResponse != "y") break;

                // If user hits, add card to hand
                if (!userHand.Hit(deck.DealTopCard(), "User")) break;
            }

            if (userHand.Bust) Console.WriteLine("User bust! Comp wins!");
            else
            {
                // Comp hit
                while (compHand.TotalValue <= 11)
                {
                    if (!compHand.Hit(deck.DealTopCard(), "Computer")) break;
                }

                // Compare scores of computer hand vs user hand
                if (compHand.Bust) Console.WriteLine("Comp bust! User wins!");
                else
                {

                    if (userHand.TotalValue > compHand.TotalValue) Console.WriteLine("User wins!");
                    else Console.WriteLine("Computer wins! ");
                }
            }

            Console.WriteLine($"User hand total {userHand.TotalValue} and computer hand {compHand.TotalValue}");
        }
    }
}
