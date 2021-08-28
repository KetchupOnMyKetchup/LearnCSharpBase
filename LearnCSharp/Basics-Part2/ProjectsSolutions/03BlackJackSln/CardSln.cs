using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp.Basics_Part2.Projects.BlackJack
{
    /// <summary>
    /// Individual card from a standard deck
    /// </summary>
    public class CardSln
    {
        public string Name => $"{Number} of {Suit}";
        //public string Name { get { return $"{Number} of {Suit}"; } }  <-- Equivalent syntax as above

        public string Suit { get; set; }
        public string Number { get; set; }
        public string Color { get; set; }
        public int Value { get; set; } // can change to List<int> to account for Ace being 1 or 11
    }
}
