using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public static char CheckWinner(char[,] board)
    {
        // Check rows, columns, and diagonals for a winner, iterating through each row and columns
        for (int i = 0; i < 3; i++)
        {
            // Runs through each row to see if either player won
            if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != ' ')
                return board[i, 0];
            // Checks through each column to see if either player won
            if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != ' ')
                return board[0, i];
        }
        // Checks diagonal top left to bottom right
        if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != ' ')
            return board[0, 0];
        // Checks diagonal top right to bottom left
        if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != ' ')
            return board[0, 2];

        // Check for a tie
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                if (board[i, j] == ' ')
                    return ' '; // Game continues

        return 'T'; // Tie game
    }
}