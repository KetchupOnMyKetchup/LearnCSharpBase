using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp
{
    /// <summary>
    /// Welcome the user to play tic tac toe, this is a 2 player game
    /// Print a board using characters like ____ and | to create a 3x3 board and place 1-9 in like below:
    /// 1 | 2 | 3
    /// __________
    /// 4 | 5 | 6
    /// __________
    /// 7 | 8 | 9
    /// 
    /// Ask user 1 to choose a spot from 1-9
    /// Mark spot and print the board but with and 'X' or 'O' in place of the spot they chose, for example if they chose 3:
    /// 1 | 2 | X
    /// __________
    /// 4 | 5 | 6
    /// __________
    /// 7 | 8 | 9
    /// 
    /// Ask user 2 to choose an available spot from 1-9. 
    /// Mark spot and reprint board. Ask user 1 to choose a spot, and so on, keep looping. 
    /// Should find a way to check if there is a winner after each turn.
    /// If there is a winner or the game is a draw/ends, quit game, announce winner, ask if they want to play again. 
    /// 
    /// BONUS 1: Error if they chose a spot that cannot be chosen like 3 in example above.
    /// BONUS 2: Allow players to choose if they want to be 'X' or 'O' at the beginning
    /// </summary>
    public class TicTacToeSln
    {
        public void Run()
        {
            Console.WriteLine("Let's play Tic Tac Toe!");
            char[] arr = new char[9]
            {
               '1', '2', '3', '4', '5', '6', '7', '8', '9'
            };
            GameSln g = new GameSln();
            g.DisplayBoard(arr);
            bool isPlayerOne = true;
            bool isDraw = false;
            bool isWin = false;
            while (!isWin && !isDraw)
            {
                if (isPlayerOne == true)
                {
                    Console.WriteLine("Player one choose a number.");
                    string input = Console.ReadLine();
                    int numInput = int.Parse(input);
                    arr[numInput - 1] = 'x';
                    isPlayerOne = false;
                    g.DisplayBoard(arr);
                }
                else
                {
                    Console.WriteLine("Player two choose a number.");
                    string input = Console.ReadLine();
                    int numInput = int.Parse(input);
                    arr[numInput - 1] = 'o';
                    isPlayerOne = true;
                    g.DisplayBoard(arr);
                }
                isWin = g.CheckForDrawSln(arr);
                isDraw = g.CheckForWinSln(arr);
            }
            Console.WriteLine("Game over. Would you like to play again?");
            Console.ReadLine();
        }
    }

    public class GameSln
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

        public bool CheckForWinSln(char[] arr)
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
        public bool CheckForDrawSln(char[] arr)
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
