using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCompositePattern
{
    public class FileSystemImageLoader : IImageLoaderStrategy
    {
        public string LoadImage(string href)
        {
            return $"<img src=\"file://{href}\" alt=\"Local Image\" />";
        }
    }
}
