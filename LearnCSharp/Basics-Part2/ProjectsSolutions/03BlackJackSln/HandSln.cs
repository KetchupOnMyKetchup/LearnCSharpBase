using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp.Basics_Part2.Projects.BlackJack
{
    /// <summary>
    /// Represents a user's set of cards
    /// </summary>
    public class HandSln
    {
        public HandSln()
        {
            Cards = new List<CardSln>();
        }

        public int TotalValue { get; set; }

        public List<CardSln> Cards { get; set; }

        public bool Bust => TotalValue > 21;
        public bool Bust2 { get { return TotalValue > 21; } } 
        public bool Bust3 
        { get 
            {   
                if (TotalValue > 21) return true;
                else return false;
            } 
        }

        public bool IsOver21(int val)
        {
            return val > 21;
        }

        public void AddCard(CardSln card, bool userSeesCard, string user)
        {
            Cards.Add(card);
            TotalValue += card.Value;

            if (userSeesCard)
            {
                Console.WriteLine($"Card dealt to {user} hand is: {card.Name}");
            }
        }

        public bool Hit(CardSln card, string user)
        {
            // All hits are seen by all users
            AddCard(card, true, user);

            if (TotalValue > 21) return false;
            return true;
        }
    }
}
