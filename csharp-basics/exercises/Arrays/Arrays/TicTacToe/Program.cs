using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];

        private static void Main(string[] args)
        {
            Initialize(board);
            DisplayBoard(board);
            Game();
        }

       private static void Game()
        {
            char player = 'X';

            while (GetWinner(player) == false || CheckIfDraw(player) == false)
            {
                Console.Clear();
                DisplayBoard(board);

                if (GetWinner(player) == true)
                {
                    Console.WriteLine($" Player {player} has won !");
                    break;
                }

                if (CheckIfDraw(player) == true)
                {
                    Console.WriteLine("DRAW!!");
                    break;
                }

                Console.Write("Please enter a row: ");
                int row = int.Parse(Console.ReadLine());
                Console.Write("Please enter a col: ");
                int col = int.Parse(Console.ReadLine());

                board[row, col] = player;
                player = ChangeTurn(player);
            }
        }

       private static char ChangeTurn(char currentPlayer)
        {
            return currentPlayer == 'X' ? 'O' : 'X';
        }

       private static void Initialize(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = ' ';
                }
            }
        }

        private static void DisplayBoard(char[,] board)
        {
            Console.WriteLine("  | 0 | 1 | 2 |");
            for (int row = 0; row < 3; row++)
            {
                Console.Write(row + " | ");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col]);
                    Console.Write(" | ");
                }

                Console.WriteLine();
            }
        }

       private static bool GetWinner(char player)
        {
            return player == board[0, 0] && player == board[0, 1] && player == board[0, 2] ||
            player == board[1, 0] && player == board[1, 1] && player == board[1, 2] ||
            player == board[2, 0] && player == board[2, 1] && player == board[2, 2] ||
            player == board[0, 0] && player == board[1, 0] && player == board[2, 0] ||
            player == board[0, 1] && player == board[1, 1] && player == board[2, 1] ||
            player == board[0, 2] && player == board[1, 2] && player == board[2, 2] ||
            player == board[0, 0] && player == board[1, 1] && player == board[2, 2] ||
            player == board[0, 2] && player == board[1, 1] && player == board[2, 0];
        }

       private static bool CheckIfDraw(char player)
       {
           for (int r = 0; r < 3; r++)
           {
               for (int c = 0; c < 3; c++)
               {
                   if (board[r, c] == ' ')
                   {
                       return false;
                   }
               }
           }
           return true;
       }
    }
}
