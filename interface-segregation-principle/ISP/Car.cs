using System;

namespace ISP
{
    internal class Car : ILandVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving to the sunset.");
        }
    }
}
