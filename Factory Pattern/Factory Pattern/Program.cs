using Factory_Pattern;
using System.Data.Common;

Console.WriteLine("What type of vehicle would you like to build?");
var userInput = Console.ReadLine();

VehicleFactory = VehicleFactory.GetVehicle(userInput);
//IDBConnection connection = VehicleFactory = VehicleFactory.GetVehicle(userInput);