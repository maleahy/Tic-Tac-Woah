using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tic_Tac_Woah
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Welcome the user to the game
            Console.WriteLine("Welcome to the Game!");

            //Create a game board array to store the players’ choices

            char[,] board = new char[3, 3] {
                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' }
            };
            //Ask each player in turn for their choice and update the game board array
            //Print the board by calling the method in the supporting class
            //Check for a winner by calling the method in the supporting class, and notify the players when a win has occurred and which player won the game

        }
}
}
