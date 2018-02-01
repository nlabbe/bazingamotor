using System;
namespace BazingaMotors.Models
{
    public class Urban : AbstractBus
    {
        public Urban(IEngine engine) : this(engine, VehicleColour.Unpainted)
        {
        }

        public Urban(IEngine engine, VehicleColour colour) : base(engine, colour)
        {
            
        }
    }
}
