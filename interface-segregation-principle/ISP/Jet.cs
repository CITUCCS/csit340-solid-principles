using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
