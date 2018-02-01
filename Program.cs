using System;
using BazingaMotors.Models;

namespace BazingaMotors
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hola, Bienvenido a Bazinga Motor Company");
                Console.Read();
                Console.Write("Ingrese vehículo");
                Console.Read();
                string vehicle = Console.ReadLine();

                AbstractVehicleFactory factory = null;

                switch (vehicle)
                {
                    case "ebus":
                        factory = new EbusFactory();
                        break;
                    case "micro":
                        factory = new MicroFactory();
                        break;
                    case "urban":
                        factory = new UrbanFactory();
                        break;
                    case "articulated":
                        factory = new ArticulatedFactory();
                        break;
                    default:
                        break;
                }

                IBody vehicleBody = factory.CreateBody();
                IChassis vehicleChassis = factory.CreateChassis();

                Console.WriteLine(vehicleBody.BodyParts);
                Console.WriteLine(vehicleChassis.ChassisParts);

                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Vehículo no valido :( ." + ex);
            }

        }
    }
}
