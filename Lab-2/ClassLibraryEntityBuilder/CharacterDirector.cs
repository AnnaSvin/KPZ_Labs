using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEntityBuilder
{
    public class CharacterDirector
    {
        public Character ConstructHero(ICharacterBuilder builder)
        {
            return builder
                .SetName("Brave Knight")
                .SetHeight(1.85)
                .SetBodyType("Muscular")
                .SetHairColor("Blond")
                .SetEyeColor("Blue")
                .SetClothing("Shining Armor")
                .AddInventoryItem("Sword")
                .AddInventoryItem("Shield")
                .AddSpecialAction("Saves the kingdom")
                .AddSpecialAction("Rescues villagers")
                .Build();
        }

        public Character ConstructEnemy(ICharacterBuilder builder)
        {
            return builder
                .SetName("Dark Sorcerer")
                .SetHeight(1.90)
                .SetBodyType("Slim")
                .SetHairColor("Black")
                .SetEyeColor("Red")
                .SetClothing("Dark Robes")
                .AddInventoryItem("Magic Staff")
                .AddSpecialAction("Destroys villages")
                .AddSpecialAction("Curses innocent people")
                .Build();
        }
    }
}
