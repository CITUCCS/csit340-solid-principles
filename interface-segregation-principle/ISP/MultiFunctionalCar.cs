using System;

namespace ISP
{
    public class MultiFunctionalCar : IHybridVehicle
    {
        private readonly ILandVehicle _landVehicleBehavior;
        private readonly IAirVehicle _airVehicleBehavior;

        public MultiFunctionalCar(ILandVehicle landVehicleBehavior, IAirVehicle airVehicleBehavior)
        {
            _landVehicleBehavior = landVehicleBehavior;
            _airVehicleBehavior = airVehicleBehavior;
        }

        public void Drive()
        {
            //actions to start driving car
            _landVehicleBehavior.Drive();
        }
        public void Fly()
        {
            //actions to start flying
            _airVehicleBehavior.Fly();
        }
    }
}
