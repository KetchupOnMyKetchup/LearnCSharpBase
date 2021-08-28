using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp.Basics_Part1.Homework.HwSolutions
{
    class Hw4Solutions
    {
        // -----------------------------------------------------------
        // Problem 1: Refactor the method from Problem1A into Problem1B so that it is 1 line instead of 3 lines. 
        // Note this code is from the Tic Tac Toe game.
        // -----------------------------------------------------------
        public void Problem1A()
        {
            string input = Console.ReadLine();
            int numInput = int.Parse(input);
            arr[numInput - 1] = 'x';
        }

        public void Problem1B()
        {
            arr[int.Parse(Console.ReadLine()) - 1] = 'x';
        }

        // -----------------------------------------------------------
        // Problem 2: Refactor the method from Problem2A into Problem2B 
        // so that the Console.WriteLine() methods are on the same line as the if/else if/else
        // Note this code is from Fizz Buzz.
        // -----------------------------------------------------------
        public void Problem2A(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void Problem2B(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                if (i % 3 == 0) Console.WriteLine("Fizz");
                else if (i % 5 == 0) Console.WriteLine("Buzz");
                else Console.WriteLine(i);
            }
        }

        // -----------------------------------------------------------
        // Problem 3: Refactor the method from Problem3A into Problem3B from 6 lines of code to 4 lines of code. 
        // Note this code is from the Calculator project. 
        // -----------------------------------------------------------
        public void Problem3A(int num)
        {
            Console.WriteLine("Enter your first number");
            string input1 = Console.ReadLine();
            decimal firstNum = decimal.Parse(input1);

            Console.WriteLine("Enter your second number");
            string input2 = Console.ReadLine();
            decimal secondNum = decimal.Parse(input2);
        }

        public void Problem3B(int num)
        {
            Console.WriteLine("Enter your first number");
            decimal firstNum = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number");
            decimal secondNum = decimal.Parse(Console.ReadLine());
        }


        // -----------------------------------------------------------
        // Problem 4: Refactor the method from Problem4A into Problem4B from 5 lines of code to 3 lines of code. 
        // Note this code is from the Marbles project. 
        // -----------------------------------------------------------
        public void Problem4A(List<string> bags)
        {
            Console.WriteLine($"Pick a bag # between 1 and {bags.Count}");
            int bagNum = int.Parse(Console.ReadLine());

            Console.WriteLine("How many marbles would you like to put in it?");
            int numMarbles = int.Parse(Console.ReadLine());

            FillBag(bags[bagNum - 1], numMarbles);
        }

        public void Problem4B(List<string> bags)
        {
            Console.WriteLine($"Pick a bag # between 1 and {bags.Count}");

            Console.WriteLine("How many marbles would you like to put in it?");

            FillBag(bags[int.Parse(Console.ReadLine()) - 1], int.Parse(Console.ReadLine()));
        }

        // -----------------------------------------------------------
        // Problem 5: Refactor the method from DealCard1 into DealCard2 into how you would want to see it in production code.
        // This is a good example of learning when to and when not to reduce your code syntax.
        // Sometimes you can reduce stuff, sometimes you can't :) Good luck!
        // Note this code is from the Blackjack project. 
        // -----------------------------------------------------------
        private int DealCard1(List<string> deck, bool displayCard, string player)
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

        private int DealCard2(List<string> deck, bool displayCard, string player)
        {
            Random rand = new Random();

            var cardDrawn = rand.Next(0, deck.Count);

            if (displayCard) Console.WriteLine($"{player} card is: {deck[cardDrawn]}");

            deck.RemoveAt(cardDrawn);

            return AddCardValueToScore(deck[cardDrawn]);
        }


        // -----------------------------------------------------------
        // Ignore the below, just here to make the code work
        // -----------------------------------------------------------
        char[] arr = new char[9] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private void FillBag(string bags, int numMarbles) { }
        private int AddCardValueToScore(string card) { return 0; }

        // for debugging
        public void Run()
        {
            var deck = new List<string>() { "card1", "card2" };
            var displayCard = true;
            var player = "Player";
            //DealCard1(deck, displayCard, player);
            DealCard2(deck, displayCard, player);
        }
    }
}

