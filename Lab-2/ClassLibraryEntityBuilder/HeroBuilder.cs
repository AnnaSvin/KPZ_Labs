using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEntityBuilder
{
    public class HeroBuilder : ICharacterBuilder
    {
        private readonly Character _character = new();

        public ICharacterBuilder SetName(string name) { _character.SetName(name); return this; }
        public ICharacterBuilder SetHeight(double height) { _character.SetHeight(height); return this; }
        public ICharacterBuilder SetBodyType(string bodyType) { _character.SetBodyType(bodyType); return this; }
        public ICharacterBuilder SetHairColor(string color) { _character.SetHairColor(color); return this; }
        public ICharacterBuilder SetEyeColor(string color) { _character.SetEyeColor(color); return this; }
        public ICharacterBuilder SetClothing(string clothing) { _character.SetClothing(clothing); return this; }
        public ICharacterBuilder AddInventoryItem(string item) { _character.AddInventoryItem(item); return this; }
        public ICharacterBuilder AddSpecialAction(string action) { _character.AddSpecialAction($"Heroic Action: {action}"); return this; }

        public Character Build() { return _character; }
    }
}
