using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Core
{
    public class GameBoard
    {
        private readonly Symbol[,] _board;

        public GameBoard()
        {
            _board = new Symbol[3, 3];
        }

        public Symbol this[int row, int col]
        {
            get => _board[row, col];
            set => _board[row, col] = value;
        }

        public bool IsCellEmpty(int row, int col)
        {
            return _board[row, col] == Symbol.None;
        }

        public bool IsFull()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (_board[i, j] == Symbol.None)
                        return false;
            return true;
        }

        public Symbol[,] GetBoardCopy()
        {
            var copy = new Symbol[3, 3];
            Array.Copy(_board, copy, _board.Length);
            return copy;
        }

        public void Clear()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    _board[i, j] = Symbol.None;
        }
    }
}
