using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Services
{
    public class RandomAI : AIPlayer
    {
        private readonly Random _random = new Random();

        public override (int Row, int Col) GetMove(string[,] board, string aiSymbol, string playerSymbol)
        {
            var availableMoves = new List<(int Row, int Col)>();
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (string.IsNullOrEmpty(board[i, j]))
                        availableMoves.Add((i, j));
                }
            }

            return availableMoves[_random.Next(availableMoves.Count)];
        }
    }
}
