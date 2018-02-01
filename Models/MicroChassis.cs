using System;
namespace BazingaMotors.Models
{
    public class MicroChassis : IChassis
    {
        public virtual string ChassisParts
        {
            get
            {
                return "Chassis parts for a Micro bus. :)";
            }
        }

        public MicroChassis()
        {
        }
    }
}
