using System;
namespace BazingaMotors.Models
{
    public class AbstractEngine : IEngine
    {
        private int size;
        private bool turbo;

        public AbstractEngine(int size, bool turbo)
        {
            this.size = size;
            this.turbo = turbo;
        }

        public virtual int Size
        {
            get
            {
                return size;

            }
        }

        public virtual bool Turbo
        {
            get
            {
                return turbo;
            }
        }

        public override string ToString()
        {
            return string.Format("[AbstractEngine: Size={0}, Turbo={1}]", Size, Turbo);
        }
    }
}
