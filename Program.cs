using System;
using BazingaMotors.Models;

namespace BazingaMotors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to Bazinga Motor Company");
            Console.WriteLine("I want a economical car, coloured blue");



            VehicleFactory busFactory = new MicroFactory();
            IVehicle bus = busFactory.Build(VehicleFactory.DrivingStyle.Economical, VehicleColour.Blue);

            Console.WriteLine(bus);

            Console.Read();

        }
    }
}
