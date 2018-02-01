using System;
namespace BazingaMotors.Models
{
    public class EbusFactory : AbstractVehicleFactory
    {
        public override IBody CreateBody()
        {
            return new EbusBody();
        }

        public override IChassis CreateChassis()
        {
            return new EbusChassis();
        }
        public EbusFactory()
        {
        }
    }
}
