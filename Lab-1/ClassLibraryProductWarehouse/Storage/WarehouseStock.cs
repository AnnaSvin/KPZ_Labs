using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProductWarehouse.Storage
{
    public class WarehouseStock
    {
        private Warehouse _warehouse;
        private IStockManager _stockManager;

        public WarehouseStock(Warehouse warehouse, IStockManager stockManager)
        {
            _warehouse = warehouse;
            _stockManager = stockManager;
        }
        public Warehouse Warehouse => _warehouse;

        public bool AddStockItem(StockItem item) => _stockManager.AddStockItem(item);

        public bool RemoveStockItem(StockItem item) => _stockManager.RemoveStockItem(item);

        public List<StockItem> GetStockItems() => _stockManager.GetStockItems();
    }
}
