using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMediatorPattern
{
    public class Runway : BaseComponent
    {
        public Guid Id { get; } = Guid.NewGuid();
        public Aircraft? OccupiedBy { get; private set; }

        public bool IsAvailable => OccupiedBy == null;

        public void AssignAircraft(Aircraft aircraft)
        {
            OccupiedBy = aircraft;
            HighLightRed();
        }

        public void FreeRunway()
        {
            OccupiedBy = null;
            HighLightGreen();
        }

        public void HighLightRed()
        {
            Console.WriteLine($"Runway {Id} is now busy!");
        }

        public void HighLightGreen()
        {
            Console.WriteLine($"Runway {Id} is now free!");
        }
    }
}
