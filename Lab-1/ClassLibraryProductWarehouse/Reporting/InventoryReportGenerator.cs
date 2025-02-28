using ClassLibraryProductWarehouse.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProductWarehouse.Reporting
{
    public class InventoryReportGenerator
    {
        public void GenerateInventoryReport(WarehouseStock warehouseStock)
        {
            Console.WriteLine($"\nСклад: \"{warehouseStock.Warehouse.Name}\"");
            Console.WriteLine("Товари:");
            foreach (var item in warehouseStock.GetStockItems())
            {
                Console.WriteLine("  " + item);
            }
        }
    }
}
