using System;
namespace BazingaMotors.Models
{
    public class Ebus : AbstractBus
    {
        public Ebus(IEngine engine) : this(engine, VehicleColour.Unpainted)
        {
        }

        public Ebus(IEngine engine, VehicleColour colour) : base(engine, colour)
        {
            
        }
    }
}
