using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class SUVCar : GenericCar
    {
        public SUVCar(string name) : base(name)
        {
            carType = "SUV";
        }

        public override int getMaxSpeed()
        {
            return 90;
        }
    }
}
