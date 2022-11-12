using Aircompany.Models;

namespace Aircompany.Planes
{
    public sealed class MilitaryPlane : Plane
    {
        public readonly MilitaryType Type;

        
        public MilitaryPlane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity, MilitaryType type)
            : base(model, maxSpeed, maxFlightDistance, maxLoadCapacity)
        {
            Type = type;
        }

        
        public override bool Equals(object obj)
        {
            var isEqual = false;
            
            if (obj is MilitaryPlane plane)
            {
                isEqual = base.Equals(obj) && Type == plane.Type;
            }

            return isEqual;
        }

        public override int GetHashCode()
        {
            var hashCode = 1701194404;
            
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + Type.GetHashCode();
            
            return hashCode;
        }
        
        public override string ToString()
        {
            return base.ToString().Replace("}", ", $type=" + Type + '}');
        }        
    }
}
