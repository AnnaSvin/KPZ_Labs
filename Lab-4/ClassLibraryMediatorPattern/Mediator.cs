using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMediatorPattern
{
    public class Mediator : IMediator
    {
        private readonly List<Runway> _runways;
        private readonly List<Aircraft> _aircrafts;

        public Mediator(List<Runway> runways, List<Aircraft> aircrafts)
        {
            _runways = runways;
            _aircrafts = aircrafts;

            foreach (var runway in runways)
                runway.SetMediator(this);
            foreach (var aircraft in aircrafts)
                aircraft.SetMediator(this);
        }

        public void Notify(object sender, string ev)
        {
            if (sender is Aircraft aircraft)
            {
                switch (ev)
                {
                    case "Land":
                        var freeRunway = _runways.FirstOrDefault(r => r.IsAvailable);
                        if (freeRunway != null)
                        {
                            Console.WriteLine($"Aircraft {aircraft.Name} is landing on runway {freeRunway.Id}.");
                            freeRunway.AssignAircraft(aircraft);
                        }
                        else
                        {
                            Console.WriteLine($"No available runway for aircraft {aircraft.Name}.");
                        }
                        break;

                    case "TakeOff":
                        var assignedRunway = _runways.FirstOrDefault(r => r.OccupiedBy == aircraft);
                        if (assignedRunway != null)
                        {
                            Console.WriteLine($"Aircraft {aircraft.Name} is taking off from runway {assignedRunway.Id}.");
                            assignedRunway.FreeRunway();
                        }
                        break;
                }
            }
        }
    }
}
