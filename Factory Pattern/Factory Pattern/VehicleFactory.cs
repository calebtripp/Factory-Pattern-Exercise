using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    internal static class VehicleFactory  //made static now all members need to be static
    {

        public static IVehicle GetVehicle(string vehicleType)
        {
            // or if if else if or =>
            switch (vehicleType toLower())
                {
                case "car":
                    return new Car();
                case "motorcycle": 
                return new Motorcycle();
                case "slingshot":
                    return new Slingshot();
               
                }
        }
    }
}
