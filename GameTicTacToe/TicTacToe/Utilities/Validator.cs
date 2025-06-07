using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TicTacToe.Utilities
{
    public static class Validator
    {
        public static bool IsValidPlayerName(string name)
        {
            return !string.IsNullOrWhiteSpace(name) && name.Length <= Constants.MaxNameLength;
        }

        public static bool IsValidSymbol(string symbol)
        {
            return symbol == Constants.PlayerX || symbol == Constants.PlayerO;
        }

        public static bool IsValidMove(int row, int col)
        {
            return row >= 0 && row < Constants.BoardSize && col >= 0 && col < Constants.BoardSize;
        }

        public static bool IsValidDatabasePath(string path)
        {
            return Regex.IsMatch(path, @"^[\w\-.\\/:]+\.db$");
        }
    }
}
