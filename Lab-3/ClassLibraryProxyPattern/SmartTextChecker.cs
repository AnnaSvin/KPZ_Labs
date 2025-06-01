using System;

public class SmartTextChecker : SmartTextReader
{
    private SmartTextReader _reader;

    public SmartTextChecker(SmartTextReader reader)
    {
        _reader = reader;
    }

    public override char[][] ReadFile(string filePath)
    {
        Console.WriteLine($"[LOG] Opening file: {filePath}");

        char[][] result = _reader.ReadFile(filePath);

        Console.WriteLine("[LOG] File read successfully.");
        Console.WriteLine($"[LOG] Lines: {result.Length}");

        int totalChars = 0;
        foreach (var line in result)
        {
            totalChars += line.Length;
        }

        Console.WriteLine($"[LOG] Total characters: {totalChars}");
        Console.WriteLine("[LOG] File closed.");

        return result;
    }
}
