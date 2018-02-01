using System;
namespace BazingaMotors.Models
{
    public abstract class VehicleFactory
    {
        public enum DrivingStyle
        {
            Economical, Midrange, Large, Ecological 
        }

        public virtual IVehicle Build(DrivingStyle style, VehicleColour colour)
        {
            IVehicle v = SelectVehicle(style);
            v.Paint(colour);
            return v;
            
        }

        //Este es el factory method!!!
        protected internal abstract IVehicle SelectVehicle(DrivingStyle style);

        public VehicleFactory()
        {
        }
    }
}
