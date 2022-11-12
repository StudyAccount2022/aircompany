namespace Aircompany.Planes
{
    public sealed class PassengerPlane : Plane
    {
        public readonly int PassengersCapacity;

        
        public PassengerPlane(string model, int maxSpeed, int maxFlightDistance, 
            int maxLoadCapacity, int passengersCapacity) :base(model, maxSpeed, maxFlightDistance, maxLoadCapacity)
        {
            PassengersCapacity = passengersCapacity;
        }

        
        public override bool Equals(object obj)
        {
            var isEqual = false;
            
            if (obj is PassengerPlane plane)
            {
                isEqual = base.Equals(obj) && PassengersCapacity == plane.PassengersCapacity;
            }

            return isEqual;
        }

        public override int GetHashCode()
        {
            var hashCode = 751774561;
            
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + PassengersCapacity.GetHashCode();
            
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString().Replace("}", ", passengersCapacity=" + PassengersCapacity + '}');
        }       
        
    }
}
