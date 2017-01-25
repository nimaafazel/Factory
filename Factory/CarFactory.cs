using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    /// <summary>
    /// This Factory class will handle the construction of all the cars without any instantiation necessary
    /// </summary>
    public static class CarFactory
    {
        public enum CarType
        {
            Sports, SUV, Truck
        }

        /// <summary>
        /// This method will construct and return a specific car class.
        /// </summary>
        /// <param name="carType">The car type</param>
        /// <param name="name">The car name</param>
        /// <returns>A new instance of a specific car, or null if no car type found.</returns>
        public static GenericCar makeCar(CarType carType, string name)
        {
            switch (carType)
            {
                case CarType.Sports:
                    return new SportsCar(name);
                    
                case CarType.SUV:
                    return new SUVCar(name);
                    
                case CarType.Truck:
                    return new TruckCar(name);                
            }
            return null;
        }
    }
}
