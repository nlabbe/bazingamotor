using System;
namespace BazingaMotors.Models
{
    public abstract class VehicleDirector
    {
        public abstract IVehicle Build(VehicleBuilder builder);

        public VehicleDirector()
        {
        }
    }
}
