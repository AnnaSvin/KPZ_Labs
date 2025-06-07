using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Services;

namespace TicTacToe.UI
{
    public partial class SettingsForm : Form
    {
        private ComboBox aiStrategyCombo;
        private Button applyBtn;
        private readonly MainForm _mainForm;

        public SettingsForm(MainForm mainForm)
        {
            _mainForm = mainForm;

            Text = "Settings";
            Width = 300;
            Height = 200;
            StartPosition = FormStartPosition.CenterScreen;

            aiStrategyCombo = new ComboBox { Left = 50, Top = 50, Width = 200 };
            aiStrategyCombo.Items.AddRange(new[] { "Minimax", "Random" });
            aiStrategyCombo.SelectedItem = Program.CurrentAI is MinimaxAI ? "Minimax" : "Random";
            Controls.Add(aiStrategyCombo);

            applyBtn = new Button { Text = "Apply", Left = 100, Top = 100 };
            applyBtn.Click += ApplySettings;
            Controls.Add(applyBtn);
        }

        private void ApplySettings(object sender, EventArgs e)
        {
            string selected = aiStrategyCombo.SelectedItem?.ToString();
            if (selected == "Minimax")
                Program.CurrentAI = new MinimaxAI();
            else
                Program.CurrentAI = new RandomAI();

            LoggerService.Log($"AI strategy changed to {selected}");

            _mainForm.ApplyNewAI();
            Close();
        }
    }
}
