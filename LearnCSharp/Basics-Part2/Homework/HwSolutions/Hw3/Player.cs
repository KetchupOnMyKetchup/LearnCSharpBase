using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp.Basics_Part2.Homework.HwSolutions.Hw3
{
    public class Player
    {
        public Player(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public int Choice { get; set; }
    }
}
