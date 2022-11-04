using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
