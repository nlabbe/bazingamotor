using System;
namespace BazingaMotors.Models
{
    public class EbusBuilder : VehicleBuilder
    {
        private AbstractBus busInProgress;

        public EbusBuilder(AbstractBus bus)
        {
            busInProgress = bus;
        }

        public override void BuildBody()
        {
            Console.WriteLine("Building Ebus body...");
            //base.BuildBody();
        }

        public override void BuildChassis()
        {
            base.BuildChassis();
            Console.WriteLine("Building Ebus chassis...");
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
