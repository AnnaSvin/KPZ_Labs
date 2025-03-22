using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDeviceProduction
{
    public class KiaomiFactory : IDeviceFactory
    {
        public IDevice CreateLaptop() => new Laptop();
        public IDevice CreateNetbook() => new Netbook();
        public IDevice CreateEBook() => new EBook();
        public IDevice CreateSmartphone() => new Smartphone();
    }
}
