﻿using System.Collections.Generic;

namespace Aircompany.Planes
{
    public abstract class Plane
    {
        public readonly string Model;
        
        public readonly int MaxSpeed;
        
        public readonly int MaxFlightDistance;
        
        public readonly int MaxLoadCapacity;

        
        public Plane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity)
        {
            Model = model;
            MaxSpeed = maxSpeed;
            MaxFlightDistance = maxFlightDistance;
            MaxLoadCapacity = maxLoadCapacity;
        }

        
        public override string ToString()
        {
            return "Plane{" +
                "model='" + Model + '\'' +
                ", maxSpeed=" + MaxSpeed +
                ", maxFlightDistance=" + MaxFlightDistance +
                ", maxLoadCapacity=" + MaxLoadCapacity +
                '}';
        }

        public override bool Equals(object obj)
        {
            var isEqual = false;
            
            if (obj is Plane plane)
            {
                isEqual = Model == plane.Model &&
                          MaxSpeed == plane.MaxSpeed &&
                          MaxFlightDistance == plane.MaxFlightDistance &&
                          MaxLoadCapacity == plane.MaxLoadCapacity;
            }

            return isEqual;
        }

        public override int GetHashCode()
        {
            var hashCode = -1043886837;
            
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Model);
            hashCode = hashCode * -1521134295 + MaxSpeed.GetHashCode();
            hashCode = hashCode * -1521134295 + MaxFlightDistance.GetHashCode();
            hashCode = hashCode * -1521134295 + MaxLoadCapacity.GetHashCode();
            
            return hashCode;
        }        

    }
}
