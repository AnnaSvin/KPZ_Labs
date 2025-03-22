using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPrototypeVirus
{
    public class Virus : IVirusPrototype
    {
        protected string _name;
        protected double _weight;
        protected int _age;
        protected string _type;
        public List<IVirusPrototype> Children { get; private set; } = new List<IVirusPrototype>();

        public Virus(string name, double weight, int age, string type)
        {
            _name = name;
            _weight = weight;
            _age = age;
            _type = type;
        }

        public Virus(Virus prototype)
        {
            _name = prototype._name;
            _weight = prototype._weight;
            _age = prototype._age;
            _type = prototype._type;
            foreach (var child in prototype.Children)
            {
                Children.Add(child.Clone());
            }
        }

        public virtual IVirusPrototype Clone()
        {
            return new Virus(this);
        }

        public void AddChild(IVirusPrototype child)
        {
            Children.Add(child);
        }

        public override string ToString()
        {
            return $"[{this.GetType().Name}] Name: {_name}, Weight: {_weight}, Age: {_age}, Type: {_type}";
        }

        public void DisplayInfo(int level = 0)
        {
            string indent = new string('-', level * 2);
            Console.WriteLine($"{indent}{this}");
            foreach (var child in Children)
            {
                ((Virus)child).DisplayInfo(level + 1);
            }
        }
    }
}
