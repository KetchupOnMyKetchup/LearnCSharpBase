using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp
{
    /// <summary>
    /// Ask user for input of a numbner
    /// Ask user for input of a second numbner
    /// Ask user for input of an operation: +, -, *, or /
    /// Calculate the and return the solution to the user
    /// BONUS: Handle if the user input something incorrectly, for example didn't enter a number or operation correctly and entered gibberish
    /// </summary>
    public class CalculatorSimpleSln
    {
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
                    decimal sum = firstNum + secondNum;
                    result = sum;
                    break;
                case "-":
                    decimal difference = firstNum - secondNum;
                    result = difference;
                    break;
                case "*":
                    decimal product = firstNum * secondNum;
                    result = product;
                    break;
                case "/":
                    decimal divisor = firstNum / secondNum;
                    result = divisor;
                    break;
                default:
                    Console.WriteLine("Sorry this wasn't a correct choice.");
                    break;
            }

            Console.WriteLine($"The solution {firstNum} {operation} {secondNum} = {result}");
            Console.Read();
        }
    }
}
