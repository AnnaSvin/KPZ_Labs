using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProductWarehouse.Storage
{
    public interface IStockManager
    {
        List<StockItem> GetStockItems();
        bool AddStockItem(StockItem item);
        bool RemoveStockItem(StockItem item);
    }
}
