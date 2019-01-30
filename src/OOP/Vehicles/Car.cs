using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : IVehicle
    {
        private double fuel;
        private double consumption;

        public double Fuel { get; private set; }
        public double Consumption { get; private set; }

        public Car(double fuel, double consumption)
        {
            this.Fuel = fuel;
            this.Consumption = consumption;
        }

        public void Drive(double distance)
        {
            if (EnoughFuel(distance))
            {
                double neededFuel = distance * (this.Consumption + 0.9);
                this.Fuel -= neededFuel;
                Console.WriteLine($"Car travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Car needs refueling");
            }
        }

        public void Refuel(double amount)
        {
            this.Fuel += amount;
        }

        private bool EnoughFuel (double distance)
        {
            double neededFuel = distance * (this.Consumption + 0.9);
            return this.Fuel >= neededFuel;
        }

        public override string ToString()
        {
            return $"Car: {this.Fuel:f2}";
        }
    }
}
