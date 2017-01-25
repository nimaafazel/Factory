using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            // we are going to have n different classes inheriting from an abstract parent class
            // the user is going to choose one class, so our program will instantiate the object of the class chosen

            // OLD WAY!

            //string carName = "ECTO1";
            //// create a reference of the parent abstract class
            //GenericCar car;

            //Console.WriteLine("Select a car type: T / S / V");
            //var key = Console.ReadKey(true);

            //switch (key.Key)
            //{
            //    case ConsoleKey.T:
            //        // Truck car
            //        car = new TruckCar(carName); // instantiate the car to a Truck
            //        useCar(car);
            //        break;

            //    case ConsoleKey.S:
            //        // Sports car
            //        car = new SportsCar(carName); // instantiate the car to a SportsCar
            //        useCar(car);
            //        break;

            //    case ConsoleKey.V:
            //        // Van car
            //        car = new SUVCar(carName); // instantiate the car to a SUV
            //        useCar(car);
            //        break;

            //    default:
            //        break;
            //}


            // FACTORY DESIGN WAY

            string carName = "ECTO1";
            // create a reference of the parent abstract class
            GenericCar car;

            Console.WriteLine("Select a car type: T / S / V");
            var key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.T:
                    // Truck car
                    car = CarFactory.makeCar(CarFactory.CarType.Truck, carName); // instantiate the car to a Truck
                    useCar(car);
                    break;

                case ConsoleKey.S:
                    // Sports car
                    car = CarFactory.makeCar(CarFactory.CarType.Sports, carName);
                    useCar(car);
                    break;

                case ConsoleKey.V:
                    // Van car
                    car = CarFactory.makeCar(CarFactory.CarType.SUV, carName);
                    useCar(car);
                    break;

                default:
                    break;
            }
        }



        // this way, if we add another car class, we only need to modify the CarFactory class, because the Program won't need to know what to instantiate,
        // it just needs to know about the abstract parent class!


        /// <summary>
        /// This method receives a GenericCar subclass and uses its methods. Depending on which subclass was received, is the outcome of the methods.
        /// </summary>
        /// <param name="car"></param>
        static void useCar(GenericCar car)
        {
            car.startCar();  // call the generic method
            Console.WriteLine("This car goes up to {0} mph", car.getMaxSpeed());   // call the implemented method
        }
    }
}
