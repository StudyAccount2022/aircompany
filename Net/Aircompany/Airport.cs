using System.Collections.Generic;
using System.Linq;
using Aircompany.Models;
using Aircompany.Planes;

namespace Aircompany
{
    public sealed class Airport
    {
        public readonly List<Plane> Planes;

        
        public Airport(IEnumerable<Plane> planes)
        {
            Planes = planes.ToList();
        }

        
        public IEnumerable<PassengerPlane> GetPassengersPlanes()
        {
            var passengerPlanes = new List<PassengerPlane>();
            
            foreach (var plane in Planes)
            {
                if (plane is PassengerPlane passengerPlane)
                {
                    passengerPlanes.Add(passengerPlane);
                }
            }
            
            return passengerPlanes;
        }

        public List<MilitaryPlane> GetMilitaryPlanes()
        {
            var militaryPlanes = new List<MilitaryPlane>();
            
            foreach (var plane in Planes)
            {
                if (plane is MilitaryPlane militaryPlane)
                {
                    militaryPlanes.Add(militaryPlane);
                }
            }
            
            return militaryPlanes;
        }

        public PassengerPlane GetPassengerPlaneWithMaxPassengersCapacity()
        {
            var passengerPlanes = GetPassengersPlanes();
            
            var passengerPlane = passengerPlanes
                .Aggregate((w, x) 
                    => w.PassengersCapacity > x.PassengersCapacity ? w : x);

            return passengerPlane;
        }

        public IEnumerable<MilitaryPlane> GetTransportMilitaryPlanes()
        {
            var transportMilitaryPlanes = new List<MilitaryPlane>();
            var militaryPlanes = GetMilitaryPlanes();
            
            foreach (var militaryPlane in militaryPlanes)
            {
                if (militaryPlane.Type == MilitaryType.Transport)
                {
                    transportMilitaryPlanes.Add(militaryPlane);
                }
            }
            
            return transportMilitaryPlanes;
        }

        public Airport SortByMaxDistance()
        {
            var airport = new Airport(Planes.OrderBy(w => w.MaxFlightDistance));

            return airport;
        }

        public Airport SortByMaxSpeed()
        {
            var airport = new Airport(Planes.OrderBy(w => w.MaxSpeed));
            
            return airport;
        }

        public Airport SortByMaxLoadCapacity()
        {
            var airport = new Airport(Planes.OrderBy(w => w.MaxLoadCapacity));
            
            return airport;
        }

        public override string ToString()
        {
            return "Airport{" +
                    "planes=" + string.Join(", ", Planes.Select(x => x.Model)) +
                    '}';
        }
    }
}
