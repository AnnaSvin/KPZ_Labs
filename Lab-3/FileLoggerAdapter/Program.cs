using System;
using System.IO.Pipelines;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        Logger consoleLogger = new Logger();
        consoleLogger.Log("Це звичайне повідомлення.");
        consoleLogger.Error("Це повідомлення про помилку.");
        consoleLogger.Warn("Це попередження.");

        FileWriter fileWriter = new FileWriter("log.txt");
        FileLoggerAdapter fileLogger = new FileLoggerAdapter(fileWriter);
        fileLogger.Log("Це звичайне повідомлення (у файл).");
        fileLogger.Error("Це повідомлення про помилку (у файл).");
        fileLogger.Warn("Це попередження (у файл).");

        Console.WriteLine("Логування завершено. Перевірте файл log.txt.");
    }
}
