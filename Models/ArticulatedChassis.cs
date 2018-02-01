using System;
namespace BazingaMotors.Models
{
    public class ArticulatedChassis : IChassis
    {
        public virtual string ChassisParts
        {
            get
            {
                return "Chassis parts for a Articulated bus. :)";
            }
        }
        public ArticulatedChassis()
        {
        }
    }
}
