using System;
using BazingaMotors.Models;

namespace BazingaMotors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to Bazinga Motor Company");
            Console.WriteLine("Let's create a eBus using builder design pattern.");

            AbstractBus bus = new Ebus(new ElectricEngine(200));

            VehicleBuilder builder = new EbusBuilder(bus);

            VehicleDirector director = new EbusDirector();

            IVehicle v = director.Build(builder);

            Console.WriteLine(v);
        }
    }
}
