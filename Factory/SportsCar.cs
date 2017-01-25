using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    /// <summary>
    /// This class inherits from Generic and implements the method getMaxSpeed.
    /// </summary>
    public class SportsCar : GenericCar
    {
        public SportsCar(string name) : base(name)
        {
            carType = "Sports";  // we override the carType to differentiate it from the GenericCar
        }

        // we are overriding an abstract method, which only had the declaration. This is mandatory.
        public override int getMaxSpeed()
        {
            return 200;
        }

        // we are overriding a vrtual method, which had a defaul implemetation. This is optional.
        public override void startCar()
        {
            //base.startCar();

            Console.WriteLine("It roars!!");
        }
    }
}
