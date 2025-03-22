using ClassLibraryDeviceProduction;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Devices from IProne brand:");
        IDeviceFactory iProneFactory = new IProneFactory();
        iProneFactory.CreateLaptop().ShowDetails();
        iProneFactory.CreateNetbook().ShowDetails();
        iProneFactory.CreateEBook().ShowDetails();
        iProneFactory.CreateSmartphone().ShowDetails();

        Console.WriteLine("\nDevices from Kiaomi brand:");
        IDeviceFactory kiaomiFactory = new KiaomiFactory();
        kiaomiFactory.CreateLaptop().ShowDetails();
        kiaomiFactory.CreateNetbook().ShowDetails();
        kiaomiFactory.CreateEBook().ShowDetails();
        kiaomiFactory.CreateSmartphone().ShowDetails();

        Console.WriteLine("\nDevices from Balaxy brand:");
        IDeviceFactory balaxyFactory = new BalaxyFactory();
        balaxyFactory.CreateLaptop().ShowDetails();
        balaxyFactory.CreateNetbook().ShowDetails();
        balaxyFactory.CreateEBook().ShowDetails();
        balaxyFactory.CreateSmartphone().ShowDetails();
    }
}