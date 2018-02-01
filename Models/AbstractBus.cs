using System;
namespace BazingaMotors.Models
{
    public abstract class AbstractBus : AbstractVehicle
    {
        public AbstractBus(IEngine engine) : this(engine, VehicleColour.Unpainted)
        {
            
        }

        public AbstractBus(IEngine engine, VehicleColour colour) : base(engine, colour)
        {
            
        }


    }   
}
