using System;
namespace BazingaMotors.Models
{
    public class Micro : AbstractBus
    {
        public Micro(IEngine engine) : this(engine, VehicleColour.Unpainted)
        {
        }

        public Micro(IEngine engine, VehicleColour colour) : base(engine, colour)
        {
            
        }
    }
}
