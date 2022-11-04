using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            ILandVehicle car = new Car();
            //car.Drive();
            

            IAirVehicle airplane = new Airplane();
            IAirVehicle jet = new Jet();
            //airplane.Fly();

            IHybridVehicle vehicle = new MultiFunctionalCar(car, jet);
            vehicle.Fly();
            vehicle.Drive();
        }
    }
}
