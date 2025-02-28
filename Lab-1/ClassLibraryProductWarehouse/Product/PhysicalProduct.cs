using ClassLibraryProductWarehouse.Monies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProductWarehouse.Product
{
    public class PhysicalProduct : BaseProduct, IShippableProduct
    {
        private Money _shippingCost;

        public Money ShippingCost => _shippingCost;

        public PhysicalProduct(string name, Money price, string unit, Money shippingCost)
            : base(name, price, unit)
        {
            _shippingCost = shippingCost;
        }

        public override Money GetTotalPrice()
        {
            return MoneyOperations.IncreasePrice(Price, _shippingCost);
        }
    }
}
