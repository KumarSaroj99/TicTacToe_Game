using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    internal class Display
    {
        public static void DisplayBoard(char[] board)
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  {board[0]}  |  {board[1]}  |  {board[2]}  ");
            Console.WriteLine("  ___|_____|___");
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  {board[3]}  |  {board[4]}  |  {board[5]}  ");
            Console.WriteLine("  ___|_____|___");
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  {board[6]}  |  {board[7]}  |  {board[8]}  ");
            Console.WriteLine("     |     |     ");
        }
    }
}
