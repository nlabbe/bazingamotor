using System;
namespace BazingaMotors.Models
{
    public class UrbanFactory : AbstractVehicleFactory
    {
        public override IBody CreateBody()
        {
            return new UrbanBody();
        }

        public override IChassis CreateChassis()
        {
            return new UrbanChassis();
        }

        public UrbanFactory()
        {
        }
    }
}
    