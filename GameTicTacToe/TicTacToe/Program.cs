using SQLitePCL;
using TicTacToe.Services;
using TicTacToe.UI;

namespace TicTacToe
{
    internal static class Program
    {
        /// <summary>
        /// Поточна AI-стратегія, яку можна змінити через SettingsForm
        /// </summary>
        public static IAIPlayerStrategy CurrentAI { get; set; } = new MinimaxAI();

        /// <summary>
        /// Головна точка входу
        /// </summary>
        [STAThread]
        static void Main()
        {
            Batteries.Init();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}