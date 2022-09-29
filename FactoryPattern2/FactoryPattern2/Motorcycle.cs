using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern2
{
    internal class Motorcycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine($"We're building a new Motorcycle!");
        }
    }
}
