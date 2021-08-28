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
    public class TicTacToe
    {
        public void Run()
        {
            
        }
    }

    public class Game
    {
        public void DisplayBoard()
        {
     
        }

        public void CheckForWin()
        {
         

        }

        public void CheckForDraw()
        {
            
        }
    }
}
