﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToeGame ticTacToeGame = new TicTacToeGame();
            char[] board = ticTacToeGame.Board();
            ticTacToeGame.Select();
            ticTacToeGame.Show_Board(board);

            Console.ReadLine();
            
        }
    }
}
