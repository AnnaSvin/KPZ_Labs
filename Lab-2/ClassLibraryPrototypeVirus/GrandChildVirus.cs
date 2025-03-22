using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPrototypeVirus
{
    public class GrandChildVirus : Virus
    {
        private bool _isResistant;
        public GrandChildVirus(string name, double weight, int age, string type, bool isResistant)
            : base(name, weight, age, type)
        {
            _isResistant = isResistant;
        }

        public GrandChildVirus(GrandChildVirus prototype) : base(prototype)
        {
            _isResistant = prototype._isResistant;
        }

        public override IVirusPrototype Clone()
        {
            return new GrandChildVirus(this);
        }

        public override string ToString()
        {
            return base.ToString() + $", Resistant: {_isResistant}";
        }
    }
}
