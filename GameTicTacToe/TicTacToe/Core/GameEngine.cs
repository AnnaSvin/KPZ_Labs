using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TicTacToe.Data;
using TicTacToe.Patterns;
using TicTacToe.Services;
using TicTacToe.Utilities;

namespace TicTacToe.Core
{
    public class GameEngine
    {
        private readonly GameBoard _board;
        private readonly Player _playerX;
        private readonly Player _playerO;
        private Player _currentPlayer;
        private GameState _state;
        private readonly GameEventNotifier _notifier;
        private readonly List<Move> _moves;

        public GameBoard Board => _board;
        public GameState State => _state;
        public Player CurrentPlayer => _currentPlayer;

        public GameEngine(Player playerX, Player playerO)
        {
            _board = new GameBoard();
            _playerX = playerX;
            _playerO = playerO;
            _currentPlayer = _playerX;
            _state = GameState.InProgress;
            _notifier = GameEventNotifier.Instance;
            _moves = new List<Move>();
        }

        public bool MakeMove(int row, int col)
        {
            if (!Validator.IsValidMove(row, col) || _state != GameState.InProgress || !_board.IsCellEmpty(row, col))
            {
                LoggerService.Log($"Недійсний хід: row={row}, col={col} від гравця {_currentPlayer.Name}");
                return false;
            }

            _board[row, col] = _currentPlayer.Symbol;
            _moves.Add(new Move(row, col, _currentPlayer.Symbol));

            LoggerService.Log($"Гравець {_currentPlayer.Name} зробив хід: row={row}, col={col}");

            _notifier.NotifyMoveMade(_currentPlayer, row, col);

            UpdateGameState();
            if (_state == GameState.InProgress)
                SwitchPlayer();

            return true;
        }

        private void SwitchPlayer()
        {
            _currentPlayer = _currentPlayer == _playerX ? _playerO : _playerX;
        }

        private void UpdateGameState()
        {
            if (CheckWin(Symbol.X))
                _state = GameState.WinX;
            else if (CheckWin(Symbol.O))
                _state = GameState.WinO;
            else if (_board.IsFull())
                _state = GameState.Draw;

            if (_state != GameState.InProgress)
            {
                SaveGameHistory();
            }
        }

        private bool CheckWin(Symbol symbol)
        {
            var b = _board;

            for (int i = 0; i < 3; i++)
            {
                if (b[i, 0] == symbol && b[i, 1] == symbol && b[i, 2] == symbol)
                    return true;
                if (b[0, i] == symbol && b[1, i] == symbol && b[2, i] == symbol)
                    return true;
            }

            if (b[0, 0] == symbol && b[1, 1] == symbol && b[2, 2] == symbol)
                return true;
            if (b[0, 2] == symbol && b[1, 1] == symbol && b[2, 0] == symbol)
                return true;

            return false;
        }

        public void Reset()
        {
            _board.Clear();
            _currentPlayer = _playerX;
            _state = GameState.InProgress;
            _moves.Clear();

            LoggerService.Log("Гру було скинуто");

            _notifier.NotifyGameReset();
        }

        private string SerializeMoves()
        {
            return JsonSerializer.Serialize(_moves);
        }

        private void SaveGameHistory()
        {
            var historyService = new GameHistoryService();

            string winnerSymbol = _state switch
            {
                GameState.WinX => ((int)Symbol.X).ToSymbol(),
                GameState.WinO => ((int)Symbol.O).ToSymbol(),
                _ => "Draw"
            };

            var record = new GameRecord
            {
                PlayerXName = _playerX.Name,
                PlayerOName = _playerO.Name,
                Winner = winnerSymbol,
                DatePlayed = DateTime.Now,
                Moves = SerializeMoves()
            };

            historyService.SaveRecord(record);

            if (winnerSymbol.IsWinningSymbol())
            {
                LoggerService.Log($"Гру завершено. Переміг: {winnerSymbol}");
            }
            else
            {
                LoggerService.Log("Гру завершено. Нічия.");
            }
        }

    }
}
