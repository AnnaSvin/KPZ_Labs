using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProductWarehouse.Storage
{
    public class Warehouse
    {
        private string _name;

        public Warehouse(string name)
        {
            _name = name;
        }

        public string Name => _name;
    }
}
