using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern2
{
    internal interface IVehicle
    {
        public void Drive() { }   //{} Necessary??
        
    }
}




//Note: These classes must conform to IVehicle and implement the Drive() method - which will just Console.WriteLine(“Building a new Car!”)

//Now we will make our static VehicleFactory class.
//It will contain a static method GetVehicle(), that will return an IVehicle based on the amount of tires it’s given as a parameter
//Call this functionality in the Main method.