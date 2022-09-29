using System;

namespace FactoryPattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of tires for the vehicle type would you like to create:");
            int tireNumber = Convert.ToInt32(Console.ReadLine());
            IVehicle vehicle = VehicleFactory.GetVehicle(tireNumber);
            vehicle.Drive();
        }
    }
}
