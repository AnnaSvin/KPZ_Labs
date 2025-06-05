using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryOwnHTML
{
    public interface IAggregate<T>
    {
        IIterator<T> CreateDepthFirstIterator();
        IIterator<T> CreateBreadthFirstIterator();
    }
}
