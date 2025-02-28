using ClassLibraryProductWarehouse.Monies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProductWarehouse.Product
{
    public interface IProduct
    {
        string Name { get; }
        string Unit { get; }
        Money Price { get; }
        Money GetTotalPrice();
    }
}
