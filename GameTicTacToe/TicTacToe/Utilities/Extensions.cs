using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Utilities
{
    public static class Extensions
    {
        public static string ToSymbol(this int value)
        {
            return value switch
            {
                1 => Constants.PlayerX,
                2 => Constants.PlayerO,
                _ => string.Empty
            };
        }

        public static bool IsWinningSymbol(this string symbol)
        {
            return symbol == Constants.PlayerX || symbol == Constants.PlayerO;
        }
    }
}
