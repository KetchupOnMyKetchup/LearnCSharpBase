using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp
{
    public class FizzBuzzSln
    {
        /// <summary>
        /// From numbers from 1 to num: 
        /// Print Fizz if its divisible by 3.
        /// Print Buzz if its divisible by 5.
        /// Print FizzBuzz if divisible by both 3 and 5.
        /// Print the number itself if not divisble by 3 or 5.
        /// Return a list of strings with all values from 1 to n.
        /// </summary>
        /// <param name="num">Should take in n which is an integer</param>
        public IList<string> Run(int n)
        {
            List<string> result = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                if (i % 15 == 0)
                {
                    result.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    result.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    result.Add("Buzz");
                }
                else 
                {
                    result.Add(i.ToString());
                }
            }

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            return result;
        }

        // Below is the shorthand syntax with if/else statments on one line
        //public IList<string> Run(int n)
        //{
        //    List<string> result = new List<string>();

        //    for (int i = 1; i <= n; i++)
        //    {
        //        if (i % 15 == 0) result.Add("FizzBuzz");
        //        else if (i % 3 == 0) result.Add("Fizz");
        //        else if (i % 5 == 0) result.Add("Buzz");
        //        else result.Add(i.ToString());
        //    }

        //    return result;
        //}
    }
}
