using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
