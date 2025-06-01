using System.IO;

public class FileWriter
{
    private string _filePath;

    public FileWriter(string filePath)
    {
        _filePath = filePath;
    }

    public void Write(string message)
    {
        File.AppendAllText(_filePath, message);
    }

    public void WriteLine(string message)
    {
        File.AppendAllText(_filePath, message + "\n");
    }
}
