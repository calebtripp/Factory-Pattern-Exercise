﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern2
{
    internal class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine($"Building a new Car!");
        }
    }
}
