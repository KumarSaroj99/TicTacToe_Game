using TicTacToe.Models;

namespace TicTacToe
{
    internal class Program
    {
        static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static char currentPlayer = 'X';

        static void Main()
        {
            
            int move;
            bool gameWon = false;

            do
            {
                Console.Clear();
                Display.DisplayBoard(board);
                Console.WriteLine($"Player {currentPlayer}, enter your move (1-9): ");
                move = int.Parse(Console.ReadLine());

                if (MoveIsValid(move))
                {
                    MakeMove(move);
                    gameWon = CheckWin();
                    if (!gameWon)
                    {
                        ChangePlayer();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid move! Press any key to try again...");
                    Console.ReadKey();
                }
            } while (!gameWon && !IsBoardFull());

            Console.Clear();
            Display.DisplayBoard(board);
            

            if (gameWon)
            {
                Console.WriteLine($"Player {currentPlayer} wins!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }
        }

        static bool MoveIsValid(int move)
        {
            return move >= 1 && move <= 9 && board[move - 1] != 'X' && board[move - 1] != 'O';
        }

        static void MakeMove(int move)
        {
            board[move - 1] = currentPlayer;
        }

        static void ChangePlayer()
        {
            currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
        }

        static bool CheckWin()
        {
            int[,] winConditions = new int[,]
            {
            {0, 1, 2}, {3, 4, 5}, {6, 7, 8}, // Rows
            {0, 3, 6}, {1, 4, 7}, {2, 5, 8}, // Columns
            {0, 4, 8}, {2, 4, 6}             // Diagonals
            };

            for (int i = 0; i < winConditions.GetLength(0); i++)
            {
                if (board[winConditions[i, 0]] == currentPlayer &&
                    board[winConditions[i, 1]] == currentPlayer &&
                    board[winConditions[i, 2]] == currentPlayer)
                {
                    return true;
                }
            }

            return false;
        }

        static bool IsBoardFull()
        {
            foreach (char spot in board)
            {
                if (spot != 'X' && spot != 'O')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
