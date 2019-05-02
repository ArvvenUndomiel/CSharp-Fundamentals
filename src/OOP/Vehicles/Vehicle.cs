using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public interface IVehicle
    {
        double Fuel { get; }
        double Consumption { get; }

        void Drive(double distance);
        void Refuel(double amount);
    }
}
