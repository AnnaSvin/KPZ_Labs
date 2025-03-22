using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDeviceProduction
{
    public class EBook : IDevice
    {
        public void ShowDetails() => Console.WriteLine("EBook created.");
    }
}
