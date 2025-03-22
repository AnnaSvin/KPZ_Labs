using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPrototypeVirus
{
    public class ChildVirus : Virus
    {
        private string _mutation;
        public ChildVirus(string name, double weight, int age, string type, string mutation)
            : base(name, weight, age, type)
        {
            _mutation = mutation;
        }

        public ChildVirus(ChildVirus prototype) : base(prototype)
        {
            _mutation = prototype._mutation;
        }

        public override IVirusPrototype Clone()
        {
            return new ChildVirus(this);
        }

        public override string ToString()
        {
            return base.ToString() + $", Mutation: {_mutation}";
        }
    }
}
