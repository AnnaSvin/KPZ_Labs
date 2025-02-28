using ClassLibraryProductWarehouse.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProductWarehouse.Reporting
{
    public class StockArrivalReportManager
    {
        public void RegisterStockArrival(StockItem stockItem, int quantity, DateTime date)
        {
            stockItem.UpdateStock(quantity, date);
            Console.WriteLine($"\nПрибуткова накладна: додано {quantity} {stockItem.Product.Unit} на склад.");
        }
    }
}