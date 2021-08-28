using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp
{
    /// <summary>
    /// Calculator with no methods or shortened variable assignment
    /// Copy and paste the previous solution in first.
    /// Then break out the Add/Subtract/Multiply/Divide parts into separate methods within the same class
    /// This is to practice passing parameters, return variables, and using methods
    /// </summary>
    public class CalculatorSln
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

            CalculatorSln calc = new CalculatorSln();

            switch (operation)
            {
                case "+":
                    result = calc.Add(firstNum, secondNum);
                    break;
                case "-":
                    result = calc.Subtract(firstNum, secondNum);
                    break;
                case "*":
                    result = calc.Multiply(firstNum, secondNum);
                    break;
                case "/":
                    result = calc.Divide(firstNum, secondNum);
                    break;
                default:
                    Console.WriteLine("Sorry this wasn't a correct choice.");
                    break;
            }

            Console.WriteLine($"The solution {firstNum} {operation} {secondNum} = {result}");
            Console.Read();
        }

        public decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public decimal Subtract(decimal num1, decimal num2)
        {
            return num1 - num2;
        }

        public decimal Multiply(decimal num1, decimal num2)
        {
            return num1 * num2;
        }

        public decimal Divide(decimal num1, decimal num2)
        {
            return num1 / num2;
        }
    }
}
