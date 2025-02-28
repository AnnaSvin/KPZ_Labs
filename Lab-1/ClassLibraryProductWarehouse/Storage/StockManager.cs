using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProductWarehouse.Storage
{
    public class StockManager : IStockManager
    {
        private List<StockItem> _stockItems;

        public StockManager()
        {
            _stockItems = new List<StockItem>();
        }

        public bool AddStockItem(StockItem item)
        {
            if (_stockItems.Contains(item))
            {
                return false;
            }

            _stockItems.Add(item);
            return true;
        }

        public bool RemoveStockItem(StockItem item)
        {
            return _stockItems.Remove(item);
        }

        public List<StockItem> GetStockItems()
        {
            return new List<StockItem>(_stockItems);
        }
    }
}