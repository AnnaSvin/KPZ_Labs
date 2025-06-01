using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        string[] lines = File.ReadAllLines("book.txt");

        var root = BookParser.ParseText(lines);

        Console.WriteLine(root.OuterHTML);

        Console.WriteLine($"\nУнікальних HTML-елементів (Flyweight): {LightElementFactory.UniqueElementsCount}");

        long mem = MemoryUtil.GetMemorySizeInBytes(root);
        Console.WriteLine($"Оцінка обсягу пам’яті: ~{mem / 1024.0:F2} КБ");
    }
}
