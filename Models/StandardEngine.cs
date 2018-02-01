using System;
namespace BazingaMotors.Models
{
    public class StandardEngine : AbstractEngine
    {
        public StandardEngine(int power, bool electric) : base(power, false)
        {
            //Standard Engine
        }
    }
}
