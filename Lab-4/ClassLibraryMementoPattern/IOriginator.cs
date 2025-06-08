using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMementoPattern
{
    public interface IOriginator
    {
        IMemento Save();
        void Restore(IMemento memento);
    }
}
