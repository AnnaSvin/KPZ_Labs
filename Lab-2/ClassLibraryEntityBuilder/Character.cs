using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEntityBuilder
{
    public class Character
    {
        private string? _name;
        private double _height;
        private string? _bodyType;
        private string? _hairColor;
        private string? _eyeColor;
        private string? _clothing;
        private List<string> _inventory = new();
        private List<string> _specialActions = new();

        public string? GetName() => _name;
        public void SetName(string name) => _name = name;

        public double GetHeight() => _height;
        public void SetHeight(double height) => _height = height;

        public string? GetBodyType() => _bodyType;
        public void SetBodyType(string bodyType) => _bodyType = bodyType;

        public string? GetHairColor() => _hairColor;
        public void SetHairColor(string color) => _hairColor = color;

        public string? GetEyeColor() => _eyeColor;
        public void SetEyeColor(string color) => _eyeColor = color;

        public string? GetClothing() => _clothing;
        public void SetClothing(string clothing) => _clothing = clothing;

        public List<string> GetInventory() => _inventory;
        public void AddInventoryItem(string item) => _inventory.Add(item);

        public List<string> GetSpecialActions() => _specialActions;
        public void AddSpecialAction(string action) => _specialActions.Add(action);

        public override string ToString()
        {
            return $"Name: {_name}, Height: {_height}, Body: {_bodyType}, Hair: {_hairColor}, Eyes: {_eyeColor}, " +
                   $"Clothing: {_clothing}, Inventory: [{string.Join(", ", _inventory)}], " +
                   $"Special Actions: [{string.Join(", ", _specialActions)}]";
        }
    }
}
