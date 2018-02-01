using System;
namespace BazingaMotors.Models
{
    public class ArticulatedBody : IBody
    {
        public virtual string BodyParts
        {
            get
            {
                return "Body shell parts for a Articulated bus :)";
            }
        }

        public ArticulatedBody()
        {
        }
    }
}
