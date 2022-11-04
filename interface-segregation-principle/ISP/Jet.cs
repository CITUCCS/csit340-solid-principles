using System;

namespace ISP
{
    public class Jet : IAirVehicle
    {
        public void Fly()
        {
            Console.WriteLine("Flying via jet!");
        }
    }
}
