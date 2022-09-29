using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern2
{
    internal class Monstrosity : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine($"That's a strange request for wheel number...I guess we're building a Monstrosity!");
        }
    }
}
