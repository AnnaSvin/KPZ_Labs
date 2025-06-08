using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMementoPattern
{
    public class Memento : IMemento
    {
        private readonly string _state;
        private readonly DateTime _date;

        public Memento(string state)
        {
            _state = state;
            _date = DateTime.Now;
        }

        public string GetState() => _state;
        public DateTime GetDate() => _date;
    }
}
