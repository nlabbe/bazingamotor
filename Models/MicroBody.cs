using System;
namespace BazingaMotors.Models
{
    public class MicroBody : IBody
    {
        public virtual string BodyParts
        {
            get
            {
                return "Body shell parts for a Micro bus :)";
            }
        }
        public MicroBody()
        {
        }
    }
}
