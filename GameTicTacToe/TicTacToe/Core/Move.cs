using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Core
{
    public class Move
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public Symbol PlayerSymbol { get; set; }

        public Move(int row, int col, Symbol symbol)
        {
            Row = row;
            Col = col;
            PlayerSymbol = symbol;
        }
    }
}
