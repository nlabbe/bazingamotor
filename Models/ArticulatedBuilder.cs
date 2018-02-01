using System;
namespace BazingaMotors.Models
{
    public class ArticulatedBuilder : VehicleBuilder
    {
        private AbstractBus busInProgress;

        public ArticulatedBuilder(AbstractBus bus)
        {
            busInProgress = bus;
        }

        public override void BuildBody()
        {
            Console.WriteLine("Building Articulated body...");
            //base.BuildBody();
        }

        public override void BuildChassis()
        {
            base.BuildChassis();
            Console.WriteLine("Building Articulated chassis...");
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
