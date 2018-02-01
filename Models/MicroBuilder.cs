using System;
namespace BazingaMotors.Models
{
    public class MicroBuilder : VehicleBuilder
    {
        private AbstractBus busInProgress;

        public MicroBuilder(AbstractBus bus)
        {
            busInProgress = bus;
        }

        public override void BuildBody()
        {
            Console.WriteLine("Building Micro body...");
            //base.BuildBody();
        }

        public override void BuildChassis()
        {
            base.BuildChassis();
            Console.WriteLine("Building Micro chassis...");
        }

        public override IVehicle Vehicle
        {
            get
            {
                return busInProgress;
            }
        }
    }
}
