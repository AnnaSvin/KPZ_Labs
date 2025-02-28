using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibraryProductWarehouse.Currency
{
    public interface ICurrency
    {
        string Code { get; }
        string Symbol { get; }
        string Name { get; }
    }
}
