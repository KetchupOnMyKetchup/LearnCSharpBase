using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp
{
    /// <summary>
    /// Requirements:
    /// Enter goal for amount of water to drink for day
    /// Allow user to keep entering amount of water they drank 
        /// + print running count of how much they drank
        /// + if they are below daily amount, print how much left
        /// + if they are above daily amount, print how much over
    /// Allow user to stop program
    /// Bonus refactor challenge: Be able to accept liters as well
    /// </summary>
    public class WaterTrackerSimpleSln
    {
        public void Run()
        {
            Console.WriteLine("Daily water goal (in ounces)?");
            int dailyGoal = int.Parse(Console.ReadLine());

            int totalWater = 0;

            Console.WriteLine("Say STOP when done.");

            while (true)
            {
                string userInput = Console.ReadLine();

                if (userInput.ToUpper() == "STOP")
                {
                    break;
                }
                else
                {
                    totalWater += int.Parse(userInput);
                    Console.WriteLine($"You drank {totalWater} ounces so far!");

                    int waterLeft = dailyGoal - totalWater;

                    if (waterLeft >= 0)
                    {
                        Console.WriteLine($"You have {waterLeft} ounces left!");
                    }
                    else
                    {
                        Console.WriteLine($"You are {-1 * waterLeft} over your goal!");
                    }
                }
            }

            Console.WriteLine($"You drank {totalWater} today. Thanks for using this app!");
            Console.Read();
        }
    }
}
