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
            for (int i = 1; i < 10; i++)
            {
                board[i] = ' ';
            }
            return board;
        }

        public void Select()
        {


            Console.WriteLine("Enter your Choice");
            Console.WriteLine("1. you will choose X\n 2. you will choose O  ");
            int option = Convert.ToInt32(Console.ReadLine());


            switch (option)
            {
                case 1:
                    Console.WriteLine("");
                    char playerOneSelection = 'X';
                    char computer = 'O';
                    break;
                case 2:
                    Console.WriteLine("");
                    playerOneSelection = 'O';
                    computer = 'X';
                    break;
                default:
                    break;

            }

        }

    }
}

