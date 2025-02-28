using ClassLibraryProductWarehouse.Monies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProductWarehouse.Product
{
    public interface IShippableProduct : IProduct
    {
        Money ShippingCost { get; }
    }
}
