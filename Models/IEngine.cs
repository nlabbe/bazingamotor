using System;
namespace BazingaMotors.Models
{
    public interface IEngine
    {
        int Power
        {
            get;
        }

        bool Electric
        {
            get;
        }

    }
}
