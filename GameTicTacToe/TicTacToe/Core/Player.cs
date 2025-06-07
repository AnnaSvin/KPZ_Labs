using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Patterns;
using TicTacToe.Services;
using TicTacToe.Utilities;

namespace TicTacToe.Core
{
    public class Player
    {
        public string Name { get; set; }
        public Symbol Symbol { get; set; }
        public bool IsAI { get; set; }

        private readonly StrategyContext _strategyContext;

        public Player(string name, Symbol symbol, bool isAI = false, IAIPlayerStrategy strategy = null)
        {
            if (!Validator.IsValidPlayerName(name))
                throw new ArgumentException($"Недопустиме ім'я гравця: '{name}'");

            if (!Validator.IsValidSymbol(symbol.ToString()))
                throw new ArgumentException($"Недопустимий символ гравця: '{symbol}'");

            Name = name;
            Symbol = symbol;
            IsAI = isAI;

            if (isAI)
            {
                _strategyContext = new StrategyContext();
                _strategyContext.SetStrategy(strategy ?? new RandomAI());
            }
        }

        public (int Row, int Col) GetMove(GameBoard board)
        {
            if (!IsAI)
                return (-1, -1);

            string[,] stringBoard = new string[Constants.BoardSize, Constants.BoardSize];

            for (int r = 0; r < Constants.BoardSize; r++)
            {
                for (int c = 0; c < Constants.BoardSize; c++)
                {
                    stringBoard[r, c] = board[r, c] == Symbol.None ? string.Empty :
                                        board[r, c] == Symbol.X ? Constants.PlayerX : Constants.PlayerO;
                }
            }

            string aiSymbol = Symbol == Symbol.X ? Constants.PlayerX : Constants.PlayerO;
            string playerSymbol = Symbol == Symbol.X ? Constants.PlayerO : Constants.PlayerX;

            return _strategyContext.ExecuteStrategy(stringBoard, aiSymbol, playerSymbol);
        }
    }

}
