using ClassLibraryProductWarehouse.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProductWarehouse.Storage
{
    public class StockItem
    {
        private IProduct _product;
        private int _quantity;
        private DateTime _lastRestockDate;

        public StockItem(IProduct product, int quantity, DateTime lastRestockDate)
        {
            _product = product;
            _quantity = quantity;
            _lastRestockDate = lastRestockDate;
        }

        public IProduct Product => _product;
        public int Quantity => _quantity;
        public DateTime LastRestockDate => _lastRestockDate;

        public void UpdateStock(int quantity, DateTime date)
        {
            _quantity += quantity;
            _lastRestockDate = date;
        }

        public bool RemoveStock(int quantity)
        {
            if (quantity > _quantity)
            {
                return false;
            }
            _quantity -= quantity;
            return true;
        }

        public override string ToString()
        {
            return $"{_product.Name} - {_quantity} {_product.Unit}";
        }
    }
}
