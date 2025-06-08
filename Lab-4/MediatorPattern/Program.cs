using ClassLibraryMediatorPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        var aircraft1 = new Aircraft("Boeing 737");
        var aircraft2 = new Aircraft("Airbus A320");
        var runway1 = new Runway();
        var runway2 = new Runway();

        var mediator = new Mediator(
            new List<Runway> { runway1, runway2 },
            new List<Aircraft> { aircraft1, aircraft2 });

        aircraft1.RequestLanding();
        aircraft2.RequestLanding();

        aircraft1.RequestTakeOff();
        aircraft2.RequestTakeOff();
    }
}