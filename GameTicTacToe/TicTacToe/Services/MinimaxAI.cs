using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Services
{
    public class MinimaxAI : AIPlayer
    {
        public override (int Row, int Col) GetMove(string[,] board, string aiSymbol, string playerSymbol)
        {
            int bestScore = int.MinValue;
            (int Row, int Col) bestMove = (-1, -1);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (string.IsNullOrEmpty(board[i, j]))
                    {
                        board[i, j] = aiSymbol;
                        int score = Minimax(board, 0, false, aiSymbol, playerSymbol);
                        board[i, j] = string.Empty;

                        if (score > bestScore)
                        {
                            bestScore = score;
                            bestMove = (i, j);
                        }
                    }
                }
            }
            return bestMove;
        }

        private int Minimax(string[,] board, int depth, bool isMaximizing, string aiSymbol, string playerSymbol)
        {
            string winner = CheckWinner(board);
            if (winner == aiSymbol) return 10 - depth;
            if (winner == playerSymbol) return depth - 10;
            if (IsBoardFull(board)) return 0;

            int bestScore = isMaximizing ? int.MinValue : int.MaxValue;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (string.IsNullOrEmpty(board[i, j]))
                    {
                        board[i, j] = isMaximizing ? aiSymbol : playerSymbol;
                        int score = Minimax(board, depth + 1, !isMaximizing, aiSymbol, playerSymbol);
                        board[i, j] = string.Empty;

                        bestScore = isMaximizing ? Math.Max(score, bestScore) : Math.Min(score, bestScore);
                    }
                }
            }
            return bestScore;
        }

        private bool IsBoardFull(string[,] board)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (string.IsNullOrEmpty(board[i, j]))
                        return false;
            return true;
        }

        private string CheckWinner(string[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                if (!string.IsNullOrEmpty(board[i, 0]) && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                    return board[i, 0];
                if (!string.IsNullOrEmpty(board[0, i]) && board[0, i] == board[1, i] && board[1, i] == board[2, i])
                    return board[0, i];
            }
            if (!string.IsNullOrEmpty(board[0, 0]) && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                return board[0, 0];
            if (!string.IsNullOrEmpty(board[0, 2]) && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                return board[0, 2];

            return null;
        }
    }
}
