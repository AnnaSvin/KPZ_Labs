using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Services;

namespace TicTacToe.Patterns
{
    public class StrategyContext
    {
        private IAIPlayerStrategy _strategy;

        public void SetStrategy(IAIPlayerStrategy strategy)
        {
            _strategy = strategy;
        }

        public (int Row, int Col) ExecuteStrategy(string[,] board, string aiSymbol, string playerSymbol)
        {
            return _strategy.GetMove(board, aiSymbol, playerSymbol);
        }
    }
}
