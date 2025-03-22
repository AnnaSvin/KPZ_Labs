using ClassLibraryEntityBuilder;
using System.Reflection.Emit;

internal class Program
{
    private static void Main(string[] args)
    {
        CharacterDirector director = new CharacterDirector();

        HeroBuilder heroBuilder = new HeroBuilder();
        Character hero = director.ConstructHero(heroBuilder);
        Console.WriteLine("Hero:");
        Console.WriteLine(hero);

        heroBuilder
            .AddInventoryItem("Healing Potion")
            .AddSpecialAction("Protects villagers");
        Console.WriteLine("\nUpdated Hero:");
        Console.WriteLine(heroBuilder.Build());

        EnemyBuilder enemyBuilder = new EnemyBuilder();
        Character enemy = director.ConstructEnemy(enemyBuilder);
        Console.WriteLine("\nEnemy:");
        Console.WriteLine(enemy);

        enemyBuilder
            .AddInventoryItem("Poison Vial")
            .AddSpecialAction("Spreads darkness");
        Console.WriteLine("\nUpdated Enemy:");
        Console.WriteLine(enemyBuilder.Build());

        HeroBuilder customHeroBuilder = new HeroBuilder();
        Character customHero = customHeroBuilder
            .SetName("Mystic Guardian")
            .SetHeight(1.75)
            .SetBodyType("Athletic")
            .SetHairColor("Silver")
            .SetEyeColor("Green")
            .SetClothing("Enchanted Robes")
            .AddInventoryItem("Magic Wand")
            .AddInventoryItem("Ancient Scroll")
            .AddSpecialAction("Guards the Sacred Forest")
            .Build();

        Console.WriteLine("\nCustom Hero:");
        Console.WriteLine(customHero);

        EnemyBuilder customEnemyBuilder = new EnemyBuilder();
        Character customEnemy = customEnemyBuilder
            .SetName("Shadow Stalker")
            .SetHeight(1.80)
            .SetBodyType("Stealthy")
            .SetHairColor("Jet Black")
            .SetEyeColor("Yellow")
            .SetClothing("Dark Cloak")
            .AddInventoryItem("Dagger")
            .AddInventoryItem("Smoke Bomb")
            .AddSpecialAction("Ambushes travelers")
            .Build();

        Console.WriteLine("\nCustom Enemy:");
        Console.WriteLine(customEnemy);
    }
}