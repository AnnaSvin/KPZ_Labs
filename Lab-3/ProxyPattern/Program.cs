using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        string testFile = "example.txt";

        File.WriteAllLines(testFile, new[] {
            "Hello world!",
            "This is a test.",
            "Proxy pattern example."
        });

        SmartTextReader baseReader = new SmartTextReader();

        Console.WriteLine("\n=== SmartTextChecker (логування) ===");
        SmartTextReader checker = new SmartTextChecker(baseReader);
        checker.ReadFile(testFile);

        Console.WriteLine("\n=== SmartTextReaderLocker (з обмеженням доступу) ===");
        SmartTextReader locker = new SmartTextReaderLocker(baseReader, @"secret|forbidden|example\.txt");
        locker.ReadFile(testFile);

        Console.WriteLine("\n=== SmartTextReaderLocker (доступ дозволено) ===");
        locker = new SmartTextReaderLocker(baseReader, @"secret|forbidden");
        char[][] result = locker.ReadFile(testFile);

        foreach (var line in result)
        {
            Console.WriteLine(new string(line));
        }

        File.Delete(testFile);
    }
}
