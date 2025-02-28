using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProductWarehouse.Currency
{
    public class EUR : ICurrency
    {
        public string Code => "EUR";
        public string Symbol => "€";
        public string Name => "Euro";
    }
}
