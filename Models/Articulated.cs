using System;
namespace BazingaMotors.Models
{
    public class Articulated : AbstractBus
    {
        public Articulated(IEngine engine) : this(engine, VehicleColour.Unpainted)
        {
        }

        public Articulated(IEngine engine, VehicleColour colour) : base(engine,  colour)
        {
            
        }
    }
}
