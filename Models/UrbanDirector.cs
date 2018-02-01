using System;
namespace BazingaMotors.Models
{
    public class UrbanDirector : VehicleDirector
    {
        public override IVehicle Build(VehicleBuilder builder)
        {
            builder.BuildBody();
            builder.BuildChassis();

            return builder.Vehicle;
        }

        public UrbanDirector()
        {
        }
    }
}
