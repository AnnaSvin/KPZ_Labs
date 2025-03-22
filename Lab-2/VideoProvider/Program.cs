using ClassLibraryVideoProdiver;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        SubscriptionFactory webSite = new WebSite();
        SubscriptionFactory managerCall = new ManagerCall();
        SubscriptionFactory mobileApp = new MobileApp();

        Console.WriteLine("WebSite Subscriptions:");
        Console.WriteLine(webSite.CreateSubscription("Domestic"));
        Console.WriteLine(webSite.CreateSubscription("Educational"));
        Console.WriteLine(webSite.CreateSubscription("Premium"));

        Console.WriteLine("\nManagerCall Subscriptions:");
        Console.WriteLine(managerCall.CreateSubscription("Domestic"));
        Console.WriteLine(managerCall.CreateSubscription("Educational"));
        Console.WriteLine(managerCall.CreateSubscription("Premium"));

        Console.WriteLine("\nMobileApp Subscriptions:");
        Console.WriteLine(mobileApp.CreateSubscription("Domestic"));
        Console.WriteLine(mobileApp.CreateSubscription("Educational"));
        Console.WriteLine(mobileApp.CreateSubscription("Premium"));
    }
}