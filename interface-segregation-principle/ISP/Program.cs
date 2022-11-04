using ISP;

ILandVehicle car = new Car();
car.Drive();
// car.Fly(); <--- now impossible

IAirVehicle airplane = new Airplane();
IAirVehicle jet = new Jet();
airplane.Fly();
jet.Fly();

IHybridVehicle vehicle = new MultiFunctionalCar(car, jet);
vehicle.Fly();
vehicle.Drive();
