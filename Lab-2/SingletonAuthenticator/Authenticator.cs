using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonAuthenticator
{
    public sealed class Authenticator
    {
        private static Authenticator? _instance;
        private static readonly object _lock = new object();

        public static Authenticator Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Authenticator();
                        }
                    }
                }
                return _instance;
            }
        }

        private Authenticator()
        {
            Console.WriteLine("Authenticator instance created.");
        }

        public void Authenticate(string username)
        {
            Console.WriteLine($"Authenticating user: {username}");
        }
    }
}
