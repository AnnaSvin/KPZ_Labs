using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMediatorPattern
{
    public class Aircraft : BaseComponent
    {
        public string Name { get; }
        public bool IsTakingOff { get; set; }

        public Aircraft(string name)
        {
            Name = name;
        }

        public void RequestLanding()
        {
            Console.WriteLine($"Aircraft {Name} requests landing.");
            _mediator?.Notify(this, "Land");
        }

        public void RequestTakeOff()
        {
            Console.WriteLine($"Aircraft {Name} requests take-off.");
            _mediator?.Notify(this, "TakeOff");
        }
    }
}
