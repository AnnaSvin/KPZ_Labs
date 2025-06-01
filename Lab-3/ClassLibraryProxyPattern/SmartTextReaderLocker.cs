using System;
using System.Text.RegularExpressions;

public class SmartTextReaderLocker : SmartTextReader
{
    private SmartTextReader _reader;
    private Regex _pattern;

    public SmartTextReaderLocker(SmartTextReader reader, string regexPattern)
    {
        _reader = reader;
        _pattern = new Regex(regexPattern, RegexOptions.IgnoreCase);
    }

    public override char[][] ReadFile(string filePath)
    {
        if (_pattern.IsMatch(filePath))
        {
            Console.WriteLine("Access denied!");
            return Array.Empty<char[]>();
        }

        return _reader.ReadFile(filePath);
    }
}
