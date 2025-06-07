using SQLitePCL;
using TicTacToe.Services;
using TicTacToe.UI;

namespace TicTacToe
{
    internal static class Program
    {
        /// <summary>
        /// ������� AI-��������, ��� ����� ������ ����� SettingsForm
        /// </summary>
        public static IAIPlayerStrategy CurrentAI { get; set; } = new MinimaxAI();

        /// <summary>
        /// ������� ����� �����
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