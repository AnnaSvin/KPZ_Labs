using SingletonAuthenticator;

internal class Program
{
    private static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            var t = new Thread(() =>
            {
                var instance = Authenticator.Instance;
                instance.Authenticate($"Thread {i + 1}");
                Console.WriteLine($"Thread {i + 1}: Instance ID = {instance.GetHashCode()}");
            });
            t.Start();
        }
    }
}