using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class TruckCar : GenericCar
    {
        public TruckCar(string name) : base(name)
        {
            carType = "Truck";
        }

        public override int getMaxSpeed()
        {
            return 100;
        }
    }
}
