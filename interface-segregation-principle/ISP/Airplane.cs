using System;

namespace ISP
{
    internal class Airplane : IAirVehicle
    {
        public void Fly()
        {
            Console.WriteLine("To the moon skrt");
        }
    }
}
