using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp.Homework
{
    class Hw1Solutions
    {
        // Write a method called Cat, returns nothing, and takes in to parameters. 
        // The method should print with console writeline "Hello Cat!"
        public void Cat()
        {
            Console.WriteLine("Hello Cat!");
        }

        // Write a method called Dog that returns an int and takes in no parameters. 
        // The method should return the value 1.
        public int Dog()
        {
            return 1;
        }

        // Write a method called Test that returns an int, takes in one int parameter called number.
        // The method should returns the parameter.
        public int Test(int number)
        {
            return number;
        }

        // Write a method called Add that takes in 2 parameters of type int called num1 and num2.
        // The method should return the sum of both numbers. 
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        // Write a method called Add2 that takes in 2 parameters of type decimal called num1 and num2.
        // The method should return the sum of both numbers. 
        public decimal Add2(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        // Write me a method called PersonName that takes in 2 string parameters: firstName and lastName.
        // The method should return the string full name with a space between first and last name.
        public string PersonName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }

        // Write a method called IsTen that returns a boolean and takes in 1 parameter that is an int.
        // The method should and checks to see if the value of the int is 10
        // If num is 10, return true. Otherwise, return false. 
        public bool IsTen(int num)
        {
            if (num == 10)
            {
                return true;
            }

            return false;
        }

        // Write a method called FindC that returns a boolean
        // It should creates an new character array with the letters a-e
        // Loop over your new character array with a foreach loop.
        // When it hits 'c', print out "I found letter c" and break out of the foreach loop 
        public bool CharArray()
        {
            char[] arr = new char[5] { 'a', 'b', 'c', 'd', 'e' };

            foreach (var item in arr)
            {
                if (item == 'c')
                {
                    Console.WriteLine("I found letter c.");
                    break;
                }
            }

            return true;
        }
    }
}
