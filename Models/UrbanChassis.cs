using System;
namespace BazingaMotors.Models
{
    public class UrbanChassis : IChassis
    {
        public virtual string ChassisParts
        {
            get
            {
                return "Chassis parts for a Urban bus. >:(";
            }
        }
    }
}
