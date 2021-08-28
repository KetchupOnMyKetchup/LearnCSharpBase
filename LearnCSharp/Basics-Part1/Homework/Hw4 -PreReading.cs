using System;
using System.Collections.Generic;
using System.Text;
using LearnCSharp;

namespace LearnCSharp.Homework
{
    /// <summary>
    /// This is a lesson on syntax, read through each example and understand it.
    /// You may want to use the debugger as well to run through the code if it helps.
    /// </summary>
    class Hw4PreReading
    {

        // -----------------------------------------------------------
        // Example 1: The below 4 methods are equivalent to each other
        // Sometimes an else statement is implicit and doesn't need to be spelled out. 
        // If/else statements can be put into one line if there is only 1 line of code that would be within the braces
        // -----------------------------------------------------------
        public string Example1A(int num)
        {
            if (num == 1)
            {
                return num.ToString();
            }
            else
            {
                return "";
            }
        }

        public string Example1B(int num)
        {
            if (num == 1)
            {
                return num.ToString();
            }

            return "";
        }

        public string Example1C(int num)
        {
            if (num == 1) return num.ToString();
            else return "";
        }

        public string Example1D(int num)
        {
            if (num == 1) return num.ToString();

            return "";
        }

        // -----------------------------------------------------------
        // Example 2: The below 2 methods are equivalent to each other
        // Somtimes you break things into separate variables, but in this example we don't need to as seen in Examble2B
        // -----------------------------------------------------------
        public string Example2A(int num)
        {
            string result = num.ToString();

            return result;
        }

        public string Example2B(int num)
        {
            return num.ToString();
        }


        // -----------------------------------------------------------
        // Example 3: The below example is similar to Example 2, but we need an intermediate variable "result" in order to add 10 to it. 
        // However, as you can see in Example3B, we don't need both a "result" and "final" variable. Just the "result" one.
        // -----------------------------------------------------------
        public string Example3A(int num)
        {
            int result = num + 10;
            string final = result.ToString();
            return final;
        }

        public string Example3B(int num)
        {
            int result = num + 10;
            return result.ToString();
        }


        // -----------------------------------------------------------
        // Example 4: The below 4 methods are equivalent to each other
        // Understand how you can combine these methods together.  
        // Since Console.ReadLine() returns a string, instead of making a separate variable, you can just call it right from the int.Parse method.
        // Example 4A is the easiest to debug and for beginners. 
        // In real life I would probably use Example4B in production code, it strikes the balance between readability and not too many extra variables. 
        // Example 4C could also be used in work production code, but I would use it more for class libraries that people don't touch as often as web dev code that needs debugging. 
        // -----------------------------------------------------------
        public void Example4A()
        {
            var stringNum = Console.ReadLine();
            int numBags = int.Parse(stringNum);
            var bags = SetNumberBags(numBags);
        }

        public void Example4B()
        {
            int numBags = int.Parse(Console.ReadLine());
            var bags = SetNumberBags(numBags);
        }

        public void Example4C()
        {
            var bags = SetNumberBags(int.Parse(Console.ReadLine()));
        }

        private List<string> SetNumberBags(int num)
        {
            return new List<string>();
        }

        // -----------------------------------------------------------
        // Example 5: The below 2 methods are equivalent to each other
        // There are ways multiple ways to do the syntax to add objects to lists
        // -----------------------------------------------------------
        public List<string> Example3A(string word)
        {
            List<string> words = new List<string>();
            words.Add(word);
            words.Add("test");
            words.Add("test2");
            return words;
        }

        public List<string> Example3B(string word)
        {
            List<string> words = new List<string>
            {
                word,
                "test",
                "test2"
            };

            return words;
        }
    }
}