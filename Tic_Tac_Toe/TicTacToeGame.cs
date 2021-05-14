using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class TicTacToeGame
    {
        char[] board = new char[10];
        public char[] Board()
        {
            for (int i = 1; i < board.Length; i++)
            {
                board[i] = ' ';
            }
            return board;
        }

        public char Select()
        {
            Console.WriteLine("Choose a player: X or O");
            string userChoice = Console.ReadLine();
            if (userChoice == "X") return 'X';
            if (userChoice == "O") return 'O';
            return 'X';
        }

        public void ShowBoard(char[] board)
        {
            Console.WriteLine("| " + board[1] + "| " + board[2] + "| " + board[3] + "|");
            Console.WriteLine("----------");
            Console.WriteLine("| " + board[4] + "| " + board[5] + "| " + board[6] + "|");
            Console.WriteLine("----------");
            Console.WriteLine("| " + board[7] + "| " + board[8] + "| " + board[9] + "|");
        }
    }
}

