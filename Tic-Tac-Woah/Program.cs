using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;

using Tic_Tac_Woah;
internal class Program
{
    static void Main(string[] args)
    {
        // *Welcome the user to the game
        Console.WriteLine("Welcome to the Game!");

        // *Create a game board array to store the players’ choices
        char[,] board = new char[3, 3] {
                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' }
            };
        int turn;
        // *Ask each player in turn for their choice and update the game board array
        for (turn = 0; turn < 9; turn++)
        {
            TicTacToeGame.PrintBoard(board);
            Console.WriteLine("Player " + (turn % 2 == 0 ? "X" : "O") + "'s turn. Choose a position (1-9): ");
            string input = Console.ReadLine(); // Receive user's input. (This input is string)
            int choice;
            bool isValid = int.TryParse(input, out choice); // Convert the string input to integer
            char playerSymbol = turn % 2 == 0 ? 'X' : 'O'; // Determine each player's symbol to mark

            if (isValid && choice >= 1 && choice <= 9) // Check the user input if they were between 1 to 9
            {
                int row = (choice - 1) / 3; // Calculate the row index in the array
                int col = (choice - 1) % 3; // Calculate the column index in the array

                if (board[row, col] != 'X' && board[row, col] != 'O') // Check if the board is empty
                {
                    board[row, col] = playerSymbol; // Update the game board with player's symbol
                }
                else
                {
                    Console.WriteLine("This position is already taken. Please choose a different one.");
                    turn--; // If the player made a mistake and lost their turn, give them the turn back
                    continue;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Choose a position between 1 to 9.");
                turn--; // If the player made a mistake and lost their turn, give them the turn back
                continue;
            }

            // HERE *Print the board by calling the method in the supporting class
            //TicTacToeGame.PrintBoard(board);
            //ttt.PrintBoard(board); 

            // HERE *Check for a winner by calling the method in the supporting class, and notify the players when a win has occurred and which player won the game


            string winner = TicTacToeGame.CheckWinner(board, turn);
            Console.WriteLine($"Turn: {turn}");
            if (winner != "Game continues.")
            {
                Console.WriteLine(winner);
                TicTacToeGame.PrintBoard(board);
                break;
            }


            


            /*
                if (winner != ' ')
                {
                    if (winner == 'T')
                    {
                        Console.WriteLine("The game is a tie!");
                    }
                    else
                    {
                        Console.WriteLine("Player " + (winner == 'X' ? "1" : "2") + " wins!");
                    }
                    break; // Exit the for loop
                    }
                }

                    if (turn == 9)
                    {
                        Console.WriteLine("The game is a tie!");
                    }

                    TicTacToeGame.PrintBoard(board); // Final board state */
        }
        //Console.WriteLine("Game Over");

    }
}