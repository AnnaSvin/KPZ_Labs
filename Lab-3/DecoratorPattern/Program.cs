using System;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;

class Program
{
    static void Main()
    {
        IHero warrior = new Warrior();
        Console.WriteLine($"{warrior.GetDescription()} - Power: {warrior.GetPower()}");

        warrior = new Sword(warrior);
        warrior = new Armor(warrior);
        warrior = new Artifact(warrior);
        warrior = new Sword(warrior);

        Console.WriteLine($"{warrior.GetDescription()} - Power: {warrior.GetPower()}");

        Console.WriteLine();

        IHero mage = new Mage();
        mage = new Artifact(mage);
        mage = new Armor(mage);

        Console.WriteLine($"{mage.GetDescription()} - Power: {mage.GetPower()}");
    }
}
