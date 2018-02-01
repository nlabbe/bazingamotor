using System;
namespace BazingaMotors.Models
{
    public abstract class VehicleBuilder
    {
        public virtual void BuildBody()
        {
            
        }
        public virtual void BuildChassis()
        {
            
        }

        public abstract IVehicle Vehicle { get; }

        public VehicleBuilder()
        {
        }
    }
}
