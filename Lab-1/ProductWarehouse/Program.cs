using ClassLibraryProductWarehouse.Currency;
using ClassLibraryProductWarehouse.Monies;
using ClassLibraryProductWarehouse.Product;
using ClassLibraryProductWarehouse.Reporting;
using ClassLibraryProductWarehouse.Storage;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        ICurrency eur = new EUR();
        ICurrency usd = new USD();
        ICurrency uah = new UAH();

        Money price1 = new Money(100, 50, usd);
        Money price2 = new Money(250, 99, eur);
        Money shippingCost = new Money(60, 0, eur);
        Money discount = new Money(30, 25, usd);

        Console.WriteLine("Створено першу ціну: " + price1);
        Console.WriteLine("Створено другу ціну: " + price2);

        PriceService priceService = new PriceService();
        Money reducedPrice1 = priceService.ReducePrice(price1, discount);
        Money increasedPrice2 = priceService.IncreasePrice(price2, shippingCost);
        Console.WriteLine("\nЗменшена ціна: " + reducedPrice1);
        Console.WriteLine("Збільшена ціна: " + increasedPrice2);

        DigitalProduct ebook = new DigitalProduct("E-Book", price1, "шт.");
        PhysicalProduct laptop = new PhysicalProduct("Laptop", price2, "шт.", shippingCost);

        Console.WriteLine("\nСтворено цифровий товар: " + ebook);
        Console.WriteLine("Створено фізичний товар: " + laptop);

        Console.WriteLine("\nЗагальна ціна цифрового товару: " + ebook.GetTotalPrice());
        Console.WriteLine("Загальна ціна фізичного товару (з доставкою): " + laptop.GetTotalPrice());

        Warehouse warehouse = new Warehouse("Основний склад");
        StockManager stockManager = new StockManager();
        WarehouseStock warehouseStock = new WarehouseStock(warehouse, stockManager);

        StockItem item1 = new StockItem(ebook, 10, DateTime.Now);
        StockItem item2 = new StockItem(laptop, 5, DateTime.Now);

        warehouseStock.AddStockItem(item1);
        warehouseStock.AddStockItem(item2);

        InventoryReportGenerator reportGenerator = new InventoryReportGenerator();
        reportGenerator.GenerateInventoryReport(warehouseStock);

        StockArrivalReportManager arrivalManager = new StockArrivalReportManager();
        arrivalManager.RegisterStockArrival(item1, 5, DateTime.Now);

        StockShipmentReportManager shipmentManager = new StockShipmentReportManager();
        shipmentManager.RegisterStockShipment(item2, 2);

        reportGenerator.GenerateInventoryReport(warehouseStock);
    }
}