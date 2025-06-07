using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Services
{
    public class LoggerService
    {
        private static readonly string logFilePath = "log.txt";

        public static void Log(string message)
        {
            File.AppendAllText(logFilePath, $"{DateTime.Now}: {message}{Environment.NewLine}");
        }

        public static void Clear()
        {
            File.WriteAllText(logFilePath, string.Empty);
        }
    }
}
