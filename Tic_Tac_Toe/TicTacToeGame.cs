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

        public void Board()
        {
            for (int i = 1; i < 10; i++)
            {
                board[i] = ' ';
            }
        }
    }
}
