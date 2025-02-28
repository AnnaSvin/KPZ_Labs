using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProductWarehouse.Currency
{
    public class UAH : ICurrency
    {
        public string Code => "UAH";
        public string Symbol => "₴";
        public string Name => "Ukrainian Hryvnia";
    }
}
