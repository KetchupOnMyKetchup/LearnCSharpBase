using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp.Basics_Part1.Homework
{
    // Debugging practice
    class Hw5
    {
        // -----------------------------------------------------------
        // Problem 1: This method should print the numbers 1 through 10 to console
        // Find 1 bug and fix the broken code
        // -----------------------------------------------------------
        public void CountToTen()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        // -----------------------------------------------------------
        // Problem 2: I intentionally broke the code from FizzBuzz. 
        // Test the code, find 2 bugs in it without looking at the FizzBuzz
        // Fix the broken code
        // -----------------------------------------------------------
        public void FizzBuzz(int num)
        {
            for (int i = 1; i < num; i--)
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

        // -----------------------------------------------------------
        // Problem 3: I intentionally broke the code from Marbles. 
        // Find the 1 bug in the code from Marbles project without looking at the Marbles project.
        // Fix the broken code
        // -----------------------------------------------------------
        public void FillBag(List<string> bag, int numberOfMarblesToFillBag)
        {
            string[] colors = new string[] { "red", "orange", "yellow", "green", "blue", "purple" };

            Random rand = new Random();

            for (int i = 0; i < numberOfMarblesToFillBag; i++)
            {
                int randomNum = rand.Next(0, 6);
                string color = colors[i];
                bag.Add(color);
            }
        }

        // -----------------------------------------------------------
        // Problem 4: I intentionally broke the code from Calculator. 
        // Test the code, find 2 bugs in it without looking at the Calculator project
        // Fix the broken code
        // -----------------------------------------------------------
        public void Run()
        {
            Console.WriteLine("Enter your first number");
            string input1 = Console.ReadLine();
            decimal firstNum = decimal.Parse(input1);

            Console.WriteLine("Enter your second number");
            string input2 = Console.ReadLine();
            decimal secondNum = decimal.Parse(input2);

            Console.WriteLine("Enter your operation: +, -, *, or /");
            string operation = Console.ReadLine();

            decimal result = 0;

            Calculator calc = new Calculator();

            switch (operation)
            {
                case "+":
                    result = firstNum + secondNum;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;
                case "*":
                    result = firstNum * secondNum;
                    break;
                case "/":
                    result = firstNum * secondNum;
                    break;
                default:
                    Console.WriteLine("Sorry this wasn't a correct choice.");
                    break;
            }

            Console.WriteLine($"The solution {firstNum} {operation} {firstNum} = {result}"); //
            Console.Read();
        }

        // -----------------------------------------------------------
        // Problem 5: I intentionally broke the code that creates a deck of 52 cards. 
        // Test the code, find 3 bugs in it without looking at the FizzBuzz
        // Fix the broken code
        // -----------------------------------------------------------
        public static List<string> GenerateDeck()
        {
            List<string> deck = new List<string>();

            string[] cardTypes = new string[] { "Spades", "Hearts", "Diamonds", "Clubs" };
            string[] cardValues = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "Jack", "Queen", "King" };//

            foreach (var cardType in cardTypes)
            {
                deck.Add(cardType);

                foreach (var cardValue in cardValues)
                {
                    deck.Add(cardValue + "of" + cardType);
                }
            }

            return deck;
        }
    }
}
