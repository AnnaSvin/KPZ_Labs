﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDeviceProduction
{
    public interface IDeviceFactory
    {
        IDevice CreateLaptop();
        IDevice CreateNetbook();
        IDevice CreateEBook();
        IDevice CreateSmartphone();
    }
}
