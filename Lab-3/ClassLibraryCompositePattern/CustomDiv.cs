using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCompositePatternAndFlyweight
{
    public class CustomDiv : LifecycleElementNode
    {
        public CustomDiv() : base("div", DisplayType.Block, ClosingType.WithClosingTag)
        {
        }

        public override void OnCreated()
        {
            Console.WriteLine("CustomDiv: OnCreated");
        }

        public override void OnInserted()
        {
            Console.WriteLine("CustomDiv: OnInserted");
        }
    }
}
