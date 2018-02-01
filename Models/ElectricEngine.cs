using System;
namespace BazingaMotors.Models
{
    public class ElectricEngine : AbstractEngine
    {
        public ElectricEngine(int power) : base(power, true)
        {
            //Turbo Engine.
        }
    }
}
