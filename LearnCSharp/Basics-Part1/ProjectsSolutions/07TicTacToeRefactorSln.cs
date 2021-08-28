using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp
{
    /// <summary>
    /// Copy paste original Tic Tac Toe from Project 04 and refactor it into different classes and methods
    /// It would be good to have a Board class that handles all Board related methods like printing the board, determining if there is a win or draw.
    /// </summary>
    public class TicTacToeRefactorSln
    {
        public void Run()
        {
            Console.WriteLine("Let's play Tic Tac Toe!");
            char[] arr = new char[9]
            {
               '1', '2', '3', '4', '5', '6', '7', '8', '9'
            };
            TTTGameRefactor g = new TTTGameRefactor();
            
            g.DisplayBoard(arr);
            
            bool isPlayerOne = true;
            bool isDraw = false;
            bool isWin = false;

            while (!isWin && !isDraw)
            {
                if (isPlayerOne == true)
                {
                    // Refactor here
                    PlayerTurn(arr, g, "1", 'o');
                    isPlayerOne = false;
                }
                else
                {
                    // Refactor here
                    PlayerTurn(arr, g, "2", 'x');
                    isPlayerOne = true;
                }

                isWin = g.CheckForDraw(arr);
                isDraw = g.CheckForWin(arr);
            }
            Console.WriteLine("Game over. Would you like to play again?");
            Console.ReadLine();
        }

        // Refactor here, this method is new to avoid replicating work
        private void PlayerTurn(char[] arr, TTTGameRefactor g, string playerNumber, char choice)
        {
            Console.WriteLine($"Player {playerNumber} choose a number.");
            string input = Console.ReadLine();

            int numInput = int.Parse(input);
            arr[numInput - 1] = choice;

            g.DisplayBoard(arr);
        }
    }

    public class TTTGameRefactor
    {
        public void DisplayBoard(char[] arr)
        {
            Console.WriteLine("      |       |      ");
            Console.WriteLine($" {arr[0]}    |  {arr[1]}    |  {arr[2]}  ");
            Console.WriteLine("______|_______|______");
            Console.WriteLine("      |       |      ");
            Console.WriteLine($" {arr[3]}    |  {arr[4]}    |  {arr[5]}  ");
            Console.WriteLine("______|_______|______");
            Console.WriteLine("      |       |      ");
            Console.WriteLine($" {arr[6]}    |  {arr[7]}    |  {arr[8]}  ");
            Console.WriteLine("      |       |      ");
        }

        public bool CheckForWin(char[] arr)
        {
            if (arr[0] == arr[3] && arr[0] == arr[6]) return true;
            if (arr[0] == arr[1] && arr[0] == arr[2]) return true;
            if (arr[0] == arr[4] && arr[0] == arr[8]) return true;
            if (arr[1] == arr[4] && arr[1] == arr[7]) return true;
            if (arr[2] == arr[5] && arr[2] == arr[8]) return true;
            if (arr[2] == arr[4] && arr[2] == arr[6]) return true;
            if (arr[3] == arr[4] && arr[3] == arr[5]) return true;
            if (arr[6] == arr[7] && arr[6] == arr[8]) return true;

            return false;

        }
        public bool CheckForDraw(char[] arr)
        {
            foreach (var item in arr)
            {
                if (item != 'x' && item != 'o')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
