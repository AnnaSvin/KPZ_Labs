using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCompositePattern
{
    public class ClickLogger : IEventListener
    {
        public void HandleEvent(string eventType, LightElementNode source)
        {
            Console.WriteLine($"[EVENT: {eventType}] — Element <{source.TagName}> was clicked.");
        }
    }
}
