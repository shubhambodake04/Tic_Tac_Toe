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
        public int chance;

        public void Board()
        {
            for (int i = 1; i < 10; i++)
            {
                board[i] = ' ';
            }
        }

        public void Selection()
        {
            Random random = new Random();
            switch (random.Next(0, 2))
            {
                case 0:
                    Console.WriteLine(" 1 start the Game:  ");
                    Console.WriteLine(" 1 symbol is X ");
                    chance = 1;
                    break;
                case 1:
                    Console.WriteLine(" 2 start the Game:   ");
                    Console.WriteLine("2 symbol is O  ");
                    chance = 2;
                    break;
            }
        }
    }
}
