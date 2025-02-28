using ClassLibraryProductWarehouse.Monies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProductWarehouse.Product
{
    public class DigitalProduct : BaseProduct
    {
        public DigitalProduct(string name, Money price, string unit) : base(name, price, unit) { }

        public override Money GetTotalPrice()
        {
            return Price;
        }
    }
}
