using FactoryPattern;




Console.WriteLine("How many wheels do you have?");
var answer = Console.ReadLine();


var vehicle = VehicleFactory.GetVehicle(answer);
vehicle.Drive();







