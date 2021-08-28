using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp
{
    /// <summary>
    /// Bonus problem: Data Structures & Algorithms style Tic Tac Toe
    /// Do not worry about this for normal junior dev jobs, just for fun.
    /// This is very fast performance + good on memory solution to Tic Tac Toe.
    /// </summary>
    public class DSATicTacToeSln
    {
        int[] rows;
        int[] columns;
        int diagonal;
        int antiDiagonal;
        int length;

        /** Initialize your data structure here. */
        public DSATicTacToeSln(int n)
        {
            rows = new int[n];
            columns = new int[n];
            length = n;
        }

        /** Player {player} makes a move at ({row}, {col}).
            @param row The row of the board.
            @param col The column of the board.
            @param player The player, can be either 1 or 2.
            @return The current winning condition, can be either:
                    0: No one wins.
                    1: Player 1 wins.
                    2: Player 2 wins. */
        public int Move(int row, int col, int player)
        {
            int localPlayer = player == 1 ? 1 : -1;

            // handle rows/columns count
            rows[row] += localPlayer;
            columns[col] += localPlayer;

            // diagonal and antidiagonal
            // must be 2 if's, no else if because the center tile is shared for both
            if (row == col) diagonal += localPlayer;
            if (row + col == length - 1) antiDiagonal += localPlayer;

            // check for win
            if (Math.Abs(rows[row]) == length ||
              Math.Abs(columns[col]) == length ||
              Math.Abs(diagonal) == length ||
              Math.Abs(antiDiagonal) == length)
            {
                return player;
            }

            return 0;
        }
    }
}

/**
 * Your TicTacToe object will be instantiated and called as such:
 * TicTacToe obj = new TicTacToe(n);
 * int param_1 = obj.Move(row,col,player);
 */
