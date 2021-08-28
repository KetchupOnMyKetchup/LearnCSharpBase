using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp.Basics_Part2.Projects.BlackJack
{
    /// <summary>
    /// Initializes 52 standard deck of cards
    /// </summary>
    public class DeckSln
    {
        private static readonly string[] _cardSuits = new string[] { "Spades", "Hearts", "Diamonds", "Clubs" };
        private static readonly string[] _cardValues = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

        public DeckSln()
        {
            Cards = new List<CardSln>();
            GenerateDeck();
        }

        private void GenerateDeck()
        {
            foreach (var cardType in _cardSuits)
            {
                foreach (var cardValue in _cardValues)
                {
                    CardSln card = new CardSln
                    {
                        Suit = cardType,
                        Number = cardValue,
                        Color = (cardType == "Spades" || cardType == "Clubs") ? "Black" : "Red"
                    };

                    // Without ternary
                    //card.Color = "Red";
                    //if (cardType == "Spades" || cardType == "Clubs") card.Color = "Black";


                    // Equivalent syntax to above
                    //Card card = new Card();
                    //card.Suit = cardType;
                    //card.Number = cardValue;
                    //card.Color = color;

                    bool canParse = int.TryParse(cardValue, out int result);

                        if (canParse) card.Value = result;
                        else
                        {
                            if (cardValue == "Ace") card.Value = 1;
                            else card.Value = 10;
                        }

                        Cards.Add(card);
                }
            }
        }

        private List<CardSln> Cards { get; set; }
        
        public int Count => Cards.Count; 

        //public int Count { get { return Cards.Count; }} <-- equivalen to above line

        public CardSln DealTopCard()
        {
            CardSln topCard = Cards[0];
            Cards.RemoveAt(0);
            return topCard;
        }

        public void Shuffle()
        {
            Random rand = new Random();

            for (int i = 0; i < Cards.Count; i++)
            {
                int randomNum = rand.Next(0, 52);

                var temp = Cards[i];
                Cards[i] = Cards[randomNum];
                Cards[randomNum] = temp;
            }
        }
    }
}
