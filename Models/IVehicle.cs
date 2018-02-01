using System;
namespace BazingaMotors.Models
{
    public enum VehicleColour
    {
        Unpainted, Blue, Black, Green, Red, Silver, White, Yellow
    }

    public interface IVehicle
    {
        IEngine Engine { get; }
        VehicleColour Colour { get; }
        void Paint(VehicleColour colour);


    }
}
