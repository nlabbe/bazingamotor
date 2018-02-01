using System;
namespace BazingaMotors.Models
{
    public class UrbanBuilder : VehicleBuilder
    {
        private AbstractBus busInProgress;

        public UrbanBuilder(AbstractBus bus)
        {
            busInProgress = bus;
        }

        public override void BuildBody()
        {
            Console.WriteLine("Building Urban body...");
            //base.BuildBody();
        }

        public override void BuildChassis()
        {
            base.BuildChassis();
            Console.WriteLine("Building Urban chassis...");
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
