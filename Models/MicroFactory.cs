using System;
namespace BazingaMotors.Models
{
    public class MicroFactory : AbstractVehicleFactory
    {
        public override IBody CreateBody()
        {
            return new MicroBody();
        }

        public override IChassis CreateChassis()
        {
            return new MicroChassis();
        }
        
        public MicroFactory()
        {
        }
    }
}
