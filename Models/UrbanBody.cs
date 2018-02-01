using System;
namespace BazingaMotors.Models
{
    public class UrbanBody : IBody
    {
        public virtual string BodyParts
        {
            get
            {
                return "Body shell parts for a Urban bus :)";
            }
        }
        public UrbanBody()
        {
        }
    }
}
