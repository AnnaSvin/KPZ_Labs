using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCompositePattern
{
    public interface IImageLoaderStrategy
    {
        string LoadImage(string href);
    }
}
