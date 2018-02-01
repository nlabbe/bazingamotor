using System;
namespace BazingaMotors.Models
{
    public class EbusChassis : IChassis
    {
        public virtual string ChassisParts
        {
            get
            {
                return "Chassis parts for a ebus. :)";
            }
        }
        public EbusChassis()
        {
        }
    }
}
