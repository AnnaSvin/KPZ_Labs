using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProductWarehouse.Currency
{
    public class USD : ICurrency
    {
        public string Code => "USD";
        public string Symbol => "$";
        public string Name => "US Dollar";
    }
}
