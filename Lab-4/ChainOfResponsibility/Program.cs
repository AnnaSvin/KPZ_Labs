using ClassLibraryChainOfResponsibility;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        SupportHandler level1 = new LevelOneSupport();
        SupportHandler level2 = new LevelTwoSupport();
        SupportHandler level3 = new LevelThreeSupport();
        SupportHandler level4 = new LevelFourSupport();

        level1.SetNext(level2);
        level2.SetNext(level3);
        level3.SetNext(level4);

        Console.WriteLine("=== Система підтримки користувачів ===");

        bool handled = false;

        while (!handled)
        {
            handled = level1.HandleRequest();

            if (!handled)
            {
                Console.WriteLine("Повторюємо меню, будь ласка, спробуйте ще раз.");
                Console.WriteLine();
            }
        }

        Console.WriteLine("\nДякуємо за звернення до служби підтримки!");
    }
}