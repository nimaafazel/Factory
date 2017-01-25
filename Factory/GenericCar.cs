using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    /// <summary>
    /// Abstract class that will serve as the parent class for all cars
    /// </summary>
    public abstract class GenericCar
    {
        // simple string property to differentiate all types of cars
        public string carName { get; set; }
        public string carType { get; set; }

        // constructor
        public GenericCar(string name)
        {
            carName = name;
            carType = "Generic";
        }

        // Virtual method that has a default implementation here, but can be overwritten on the subclasses
        public virtual void startCar()
        {
            Console.WriteLine("{0} type car {1} is starting", carType, carName);
        }

        // abstract method to be implemented and overwritten by every class that inherits from this one.
        public abstract int getMaxSpeed();
    }
}
