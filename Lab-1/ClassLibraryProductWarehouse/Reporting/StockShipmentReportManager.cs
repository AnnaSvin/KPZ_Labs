using ClassLibraryProductWarehouse.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProductWarehouse.Reporting
{
    public class StockShipmentReportManager
    {
        public void RegisterStockShipment(StockItem stockItem, int quantity)
        {
            if (stockItem.RemoveStock(quantity))
            {
                Console.WriteLine($"\nВидаткова накладна: відвантажено {quantity} {stockItem.Product.Unit} зі складу.");
            }
            else
            {
                Console.WriteLine("\nПомилка: недостатньо товару на складі!");
            }
        }
    }
}
