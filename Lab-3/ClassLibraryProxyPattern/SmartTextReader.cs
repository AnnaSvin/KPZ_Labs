using System;
using System.IO;
using System.Collections.Generic;

public class SmartTextReader
{
    public virtual char[][] ReadFile(string filePath)
    {
        List<char[]> lines = new List<char[]>();
        foreach (string line in File.ReadAllLines(filePath))
        {
            lines.Add(line.ToCharArray());
        }
        return lines.ToArray();
    }
}
