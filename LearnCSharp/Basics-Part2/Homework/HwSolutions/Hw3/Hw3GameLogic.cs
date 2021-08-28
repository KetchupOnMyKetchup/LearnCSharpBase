using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp.Basics_Part2.Homework.HwSolutions.Hw3
{
    public class Hw3GameLogic
    {
        int userWins = 0;
        int compWins = 0;

        public void StartGame() 
        {
            while (true)
            {
                var user = new Player("User");
                var computer = new Player("Computer");

                OfferChoices();

                PlayerChoice(user);
                PlayerChoice(computer);

                PrintFinalChoices(user.Choice, computer.Choice);
                DetermineWinner(user.Choice, computer.Choice);

                Console.WriteLine("Would you like to continue playing? (Y/N)");
                if (Console.ReadLine().ToUpper() != "Y") break;
            }
        }

        public void OfferChoices()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors");
            Console.WriteLine("Select a number of your choice: \n 1. Rock \n 2. Paper \n 3. Scissors");
        }

        public void PlayerChoice(Player player)
        {
            int n;

            if (player.Name == "Computer")
            {
                Random rnd = new Random();
                n = rnd.Next(0, 3);
            }
            else n = int.Parse(Console.ReadLine()) - 1;
            
            player.Choice = n;
        }

        public void PrintFinalChoices(int userChoice, int compChoice)
        {
            string[] choices = new string[] { "Rock", "Paper", "Scissors" };

            Console.WriteLine($"You chose {choices[userChoice]}");
            Console.WriteLine($"Computer chose {choices[compChoice]}");
        }

        public void DetermineWinner(int userChoice, int compChoice)
        {
            if (userChoice == compChoice) Console.WriteLine("Draw!");
            else if ((userChoice == 1 && compChoice == 0) || (userChoice == 0 && compChoice == 2) || (userChoice == 2 && compChoice == 1))
            {
                Console.WriteLine("User wins!");
                userWins += 1;
            }
            else
            {
                Console.WriteLine("Computer Wins!");
                compWins += 1;
            }

            Console.WriteLine($"User has won {userWins} times. Computer has won {compWins} times");
        }
    }
}
