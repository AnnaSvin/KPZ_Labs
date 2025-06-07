using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Core;

namespace TicTacToe.UI
{
    public class GamePanel : Panel
    {
        private GameEngine _engine;
        private readonly int _cellSize;

        public GamePanel(GameEngine engine)
        {
            _engine = engine;
            Width = 300;
            Height = 300;
            BackColor = Color.White;
            _cellSize = Width / 3;

            this.MouseClick += OnMouseClick;
        }

        public void SetEngine(GameEngine engine)
        {
            _engine = engine;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            var board = _engine.Board;

            for (int i = 1; i < 3; i++)
            {
                g.DrawLine(Pens.Black, i * _cellSize, 0, i * _cellSize, Height);
                g.DrawLine(Pens.Black, 0, i * _cellSize, Width, i * _cellSize);
            }

            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    var symbol = board[r, c];
                    if (symbol != Symbol.None)
                    {
                        string text = symbol == Symbol.X ? "X" : "O";
                        g.DrawString(text, new Font(FontFamily.GenericSansSerif, 24),
                                     Brushes.Black, c * _cellSize + 30, r * _cellSize + 20);
                    }
                }
            }
        }

        private void OnMouseClick(object sender, MouseEventArgs e)
        {
            int row = e.Y / _cellSize;
            int col = e.X / _cellSize;

            if (_engine.State != GameState.InProgress)
                return;

            if (_engine.MakeMove(row, col))
            {
                Invalidate();

                var current = _engine.CurrentPlayer;
                if (current.IsAI && _engine.State == GameState.InProgress)
                {
                    var (aiRow, aiCol) = current.GetMove(_engine.Board);
                    _engine.MakeMove(aiRow, aiCol);
                    Invalidate();
                }
            }
        }
    }

}
