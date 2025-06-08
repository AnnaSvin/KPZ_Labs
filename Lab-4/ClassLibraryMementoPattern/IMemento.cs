using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMementoPattern
{
    public interface IMemento
    {
        string GetState();
        DateTime GetDate();
    }
}
