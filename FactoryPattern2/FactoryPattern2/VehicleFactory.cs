using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern2
{
    internal static class VehicleFactory
    {
        public static IVehicle GetVehicle(int tireNumber)
        {
            switch (tireNumber)
            {
                case 4: return new Car();
                case 2: return new Motorcycle();
                case 3: return new Slingshot();
                default: return new Monstrosity();
            }
        }
    }
}
