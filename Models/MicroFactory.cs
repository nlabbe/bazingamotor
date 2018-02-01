using System;
namespace BazingaMotors.Models
{
    public class MicroFactory : VehicleFactory
    {
        protected internal override IVehicle SelectVehicle(DrivingStyle style)
        {
            if (style == DrivingStyle.Economical)
            {
                return new Ebus(new StandardEngine(200, false));

            }

            return new Ebus(new StandardEngine(0, false));
        }
        
        public MicroFactory()
        {
        }
    }
}
