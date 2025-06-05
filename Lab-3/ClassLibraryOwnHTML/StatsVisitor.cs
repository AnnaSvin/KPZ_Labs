using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryOwnHTML
{
    public class StatsVisitor : IVisitor
    {
        public int TextNodeCount { get; private set; } = 0;
        public int ElementNodeCount { get; private set; } = 0;
        public HashSet<string> UniqueCssClasses { get; } = new();

        public void Visit(LightTextNode textNode)
        {
            TextNodeCount++;
        }

        public void Visit(LightElementNode elementNode)
        {
            ElementNodeCount++;
            foreach (var cssClass in elementNode.CssClasses)
            {
                UniqueCssClasses.Add(cssClass);
            }
        }
    }
}
