using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Core;
using TicTacToe.Patterns;
using TicTacToe.Services;

namespace TicTacToe.UI
{
    public partial class MainForm : Form, IGameObserver
    {
        private GameEngine _engine;
        private GamePanel _gamePanel;
        private Button _btnReset, _btnHistory, _btnSettings;

        public MainForm()
        {
            Text = "Tic Tac Toe";
            Width = 335;
            Height = 450;
            StartPosition = FormStartPosition.CenterScreen;

            InitGame();
            InitUI();

            GameEventNotifier.Instance.Subscribe(this);
        }

        private void InitGame()
        {
            var playerX = new Player("Player X", Symbol.X, isAI: false);
            var playerO = new Player("Computer", Symbol.O, isAI: true, strategy: Program.CurrentAI);
            _engine = new GameEngine(playerX, playerO);
        }

        private void InitUI()
        {
            _gamePanel = new GamePanel(_engine);
            _gamePanel.Top = 10;
            _gamePanel.Left = 10;
            Controls.Add(_gamePanel);

            _btnReset = new Button { Text = "Reset", Top = 350, Left = 10 };
            _btnReset.Click += (s, e) =>
            {
                _engine.Reset();
                LoggerService.Clear();
            };
            Controls.Add(_btnReset);

            _btnHistory = new Button { Text = "History", Top = 350, Left = 100 };
            _btnHistory.Click += (s, e) => new HistoryForm().ShowDialog();
            Controls.Add(_btnHistory);

            _btnSettings = new Button { Text = "Settings", Top = 350, Left = 200 };
            _btnSettings.Click += (s, e) => new SettingsForm(this).ShowDialog();
            Controls.Add(_btnSettings);
        }

        public void ApplyNewAI()
        {
            var playerX = new Player("Player X", Symbol.X, isAI: false);
            var playerO = new Player("Computer", Symbol.O, isAI: true, strategy: Program.CurrentAI);
            _engine = new GameEngine(playerX, playerO);
            _gamePanel.SetEngine(_engine);
            LoggerService.Clear();
            _engine.Reset();
            LoggerService.Log("AI strategy reapplied and game reset.");
        }

        public void OnMoveMade(Player player, int row, int col) => _gamePanel.Invalidate();
        public void OnGameReset() => _gamePanel.Invalidate();
    }
}
