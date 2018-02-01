using System;
namespace BazingaMotors.Models
{
    public class EbusBody : IBody
    {
        public virtual string BodyParts
        {
            get
            {
                return "Body shell parts for a eBus :)";
            }
        }
        public EbusBody()
        {
        }
    }
}
