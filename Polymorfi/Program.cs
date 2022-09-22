namespace Polymorfi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Polymorfi - Polymorphism

            var car = new Car();
            var mc = new MotorCycle();

            var vehicles = new List<Vehicle>();
            vehicles.Add(car);
            vehicles.Add(mc);

            car.TopSpeed = 200;
            car.NumberOfWheels = 4;
            car.NumberOfDoors = 5;
            car.Color = "Red";

            mc.TopSpeed = 275;
            mc.NumberOfWheels = 2;
            mc.HandlebarStyle = "Normal";
            mc.Color = "Black";

            foreach (var v in vehicles)
            { 
                v.MakeSound();
                v.PrintTopSpeed();
                v.PrintNumberOfWheels();
                v.PrintInfo();
                Console.WriteLine();
            }
        }
    }
}