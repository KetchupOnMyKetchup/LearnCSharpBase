using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp
{
    /// <summary>
    /// The rock paper scissors a user vs a computer opponent
    /// Welcome the user to the Rock Paper Scissors Game
    /// Ask them if they want to choose rock, paper, or scissors and take their input in
    /// Have the computer randomize a choice between rock, paper, and scissors
    /// Calculate who wins
    /// Let user know who won and ask if user wants to continue
    /// Make game continue to loop until user does not want to continue, and keep track of overall wins/losses for the session
    /// </summary>
    class RockPaperScissorsSln
    {
        int userWins = 0;
        int compWins = 0;

        public void Run()
        {
            // Welcome to game
            Console.WriteLine("Welcome to RPS game");
            
            // while loop for game to run
            bool continueGame = true;
            while (continueGame)
            {
                // Ask user for choice 
                Console.WriteLine("Type number for your selection:\n1-->ROCK\n2-->PAPER\n3-->SCISSOR");
                string[] choices = new string[3] { "ROCK", "PAPER", "SCISSOR" };
                Console.WriteLine("Enter your choice:");
                int user = int.Parse(Console.ReadLine()) - 1;
                
                // Computer makes selection
                Random rnd = new Random();
                int n = rnd.Next(0, 3);
                
                // Print user + computer choice
                Console.WriteLine("You chose:" + choices[user]);
                Console.WriteLine("Computer:" + choices[n]);

                // Determine winner + print winner
                FindWinner(user, n);
                
                // Ask for continue or end
                Console.WriteLine("Do you want to continue(Y/N):");
                if (Console.ReadLine().ToUpper() != "Y") continueGame = false;
                Console.WriteLine("---------------------------------------");
            }

            Console.WriteLine("User wins " + userWins + " times");
            Console.WriteLine("Computer wins " + compWins + " times");
        }

        private void FindWinner(int user, int computer)
        {
            if (user == computer) Console.WriteLine("Draw! Same choices.");
            else if ((user == 1 && computer == 0) || (user == 0 && computer == 2) || (user == 2 && computer == 1))
            {
                Console.WriteLine("User wins");
                userWins += 1;
            }
            else
            {
                Console.WriteLine("Computer Wins");
                compWins += 1;
            }
        }
    }
}
