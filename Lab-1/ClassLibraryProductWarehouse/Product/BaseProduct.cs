using ClassLibraryProductWarehouse.Monies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProductWarehouse.Product
{
    public abstract class BaseProduct : IProduct
    {
        private string _name;
        private Money _price;
        private string _unit;

        public BaseProduct(string name, Money price, string unit)
        {
            _name = name;
            _price = price;
            _unit = unit;
        }

        public string Name => _name;
        public string Unit => _unit;
        public Money Price => _price;

        public override string ToString()
        {
            return $"{_name} - {_price}";
        }

        public abstract Money GetTotalPrice();
    }
}