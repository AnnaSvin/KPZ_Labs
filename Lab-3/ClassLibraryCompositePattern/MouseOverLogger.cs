using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCompositePattern
{
    public class MouseOverLogger : IEventListener
    {
        public void HandleEvent(string eventType, LightElementNode target)
        {
            Console.WriteLine($"[EVENT: {eventType}] Mouse over <{target.TagName}>");
        }
    }
}
