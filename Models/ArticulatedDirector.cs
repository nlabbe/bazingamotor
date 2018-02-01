using System;
namespace BazingaMotors.Models
{
    public class ArticulatedDirector : VehicleDirector
    {
        public override IVehicle Build(VehicleBuilder builder)
        {
            builder.BuildBody();
            builder.BuildChassis();

            return builder.Vehicle;
        }

        public ArticulatedDirector()
        {
        }
    }
}
