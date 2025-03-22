using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDeviceProduction
{
    public class Laptop : IDevice
    {
        public void ShowDetails() => Console.WriteLine("Laptop created.");
    }
}
