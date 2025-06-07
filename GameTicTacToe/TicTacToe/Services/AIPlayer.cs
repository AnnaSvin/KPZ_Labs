using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Services
{
    public abstract class AIPlayer : IAIPlayerStrategy
    {
        public abstract (int Row, int Col) GetMove(string[,] board, string aiSymbol, string playerSymbol);
    }
}
