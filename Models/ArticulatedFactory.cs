using System;
namespace BazingaMotors.Models
{
    public class ArticulatedFactory : AbstractVehicleFactory
    {
        public override IBody CreateBody()
        {
            return new ArticulatedBody();
        }

        public override IChassis CreateChassis()
        {
            return new ArticulatedChassis();
        }
        public ArticulatedFactory()
        {
        }
    }
}
