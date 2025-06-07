using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Core;

namespace TicTacToe.Patterns
{
    public interface IGameObserver
    {
        void OnMoveMade(Player player, int row, int col);
        void OnGameReset();
    }
}
