using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Core;
using TicTacToe.Data;

namespace TicTacToe.UI
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            Text = "Game History";
            Width = 350;
            Height = 400;
            StartPosition = FormStartPosition.CenterScreen;

            var box = new TextBox
            {
                Multiline = true,
                Dock = DockStyle.Fill,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical
            };

            var sb = new StringBuilder();

            var service = new GameHistoryService();
            var records = service.LoadHistory();

            foreach (var rec in records)
            {
                sb.AppendLine($"{rec.DatePlayed}: {rec.PlayerXName} vs {rec.PlayerOName} - Winner: {rec.Winner}");

                if (!string.IsNullOrWhiteSpace(rec.Moves))
                {
                    sb.AppendLine("Moves JSON:");
                    sb.AppendLine(rec.Moves);
                }
                else
                {
                    sb.AppendLine("No move data.");
                }

                sb.AppendLine(new string('-', 50));
            }

            box.Text = sb.ToString();
            Controls.Add(box);
        }
    }

}
