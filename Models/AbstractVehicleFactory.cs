using System;
namespace BazingaMotors.Models
{
    public abstract class AbstractVehicleFactory
    {
        public abstract IBody CreateBody();
        public abstract IChassis CreateChassis();

        public AbstractVehicleFactory()
        {
        }
    }
}
