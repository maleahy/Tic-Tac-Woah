using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Woah
{
    public class TicTacToeGame

    {

        // Method to print the current state of the game board
        public static void PrintBoard(char[,] board)
        {
            // This outer for loop iterates through each row of the game board (outer array). "i" is the current row index
            for (int i = 0; i < 3; i++)
            {
                // Inner for loop iterates through each column of the current row. "j" is current column index
                for (int j = 0; j < 3; j++)
                {
                    // Prints the character in the current cell (whatever the user input was, ie 'X', 'O', or ' '
                    Console.Write(board[i, j]);
                    // Checks if the current column 'j' is less than 2 and prints the vertical lines
                    if (j < 2) Console.Write(" | ");
                }
                // prints to the next line
                Console.WriteLine();
                // Checks the row to print the horizontal dividers to visually separate
                if (i < 2) Console.WriteLine("---------");
            }
        }



        // Method to check for a winner or a tie
        public static string CheckWinner(char[,] board, int turn)
        {
            // Check rows, columns, and diagonals for a winner, iterating through each row and columns
            for (int i = 0; i < 3; i++)
            {
                // Runs through each row to see if either player won
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                    return $"Player {board[i, 0]} wins.";
                // Checks through each column to see if either player won
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                    return $"Player {board[0, i]} wins.";
            }
            // Checks diagonal top left to bottom right
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                return $"Player {board[0, 0]} wins.";
            // Checks diagonal top right to bottom left
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                return $"Player {board[0, 2]} wins.";

            if (turn == 9)
                return "Game is a tie!";
            return "Game continues.";


        }
    }
}

