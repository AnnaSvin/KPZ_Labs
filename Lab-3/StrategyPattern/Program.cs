using ClassLibraryCompositePattern;

internal class Program
{
    private static void Main(string[] args)
    {
        var localImage = new ImageElement("C:/Users/svinc/Desktop/KPZ_Labs/Lab-3/StrategyPattern/bin/Debug/net9.0/images/photo.png");
        Console.WriteLine("Local image HTML:");
        Console.WriteLine(localImage.OuterHTML);

        var networkImage = new ImageElement("https://upload.wikimedia.org/wikipedia/commons/thumb/4/4b/Chateau_de_chambord.jpg/320px-Chateau_de_chambord.jpg");
        Console.WriteLine("Network image HTML:");
        Console.WriteLine(networkImage.OuterHTML);
    }
}