using System;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] carInfo = Console.ReadLine().Split(' ');
            string [] truckInfo = Console.ReadLine().Split(' ');

            IVehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));
            IVehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string [] command = Console.ReadLine().Split(' ');

                if (command[0] == "Drive")
                {
                    if (command[1] == "Car")
                    {
                        car.Drive(double.Parse(command[2]));
                    }
                    else if (command[1] == "Truck")
                    {
                        truck.Drive(double.Parse(command[2]));
                    }
                }
                else if (command[0] == "Refuel")
                {
                    if (command[1] == "Car")
                    {
                        car.Refuel(double.Parse(command[2]));
                    }
                    else if (command[1] == "Truck")
                    {
                        truck.Refuel(double.Parse(command[2]));
                    }
                }
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
        }
    }
}
