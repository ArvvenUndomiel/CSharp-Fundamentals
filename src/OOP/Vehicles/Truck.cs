using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck :IVehicle
    {
        private double fuel;
        private double consumption;

        public double Fuel { get; private set; }
        public double Consumption { get; private set; }

        public Truck(double fuel, double consumption)
        {
            this.Fuel = fuel;
            this.Consumption = consumption;
        }

        public void Drive(double distance)
        {
            if (EnoughFuel(distance))
            {
                double neededFuel = distance * (this.Consumption + 1.6);
                this.Fuel -= neededFuel;
                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public void Refuel(double amount)
        {
            this.Fuel += 0.95*amount;
        }

        private bool EnoughFuel(double distance)
        {
            double neededFuel = distance * (this.Consumption + 1.6);
            return this.Fuel >= neededFuel;
        }

        public override string ToString()
        {
            return $"Truck: {this.Fuel:f2}";
        }
    }
}
