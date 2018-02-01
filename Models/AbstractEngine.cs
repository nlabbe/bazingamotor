using System;
namespace BazingaMotors.Models
{
    public abstract class AbstractEngine : IEngine
    {
        private int power;
        private bool electric;

        public AbstractEngine(int power, bool electric)
        {
            this.power = power;
            this.electric = electric;
        }

        public virtual int Power
        {
            get
            {
                return power;

            }
        }

        public virtual bool Electric
        {
            get
            {
                return electric;
            }
        }

        public override string ToString()
        {
            return string.Format("[AbstractEngine: Power={0}, Electric={1}]", power, electric);
        }
    }
}
