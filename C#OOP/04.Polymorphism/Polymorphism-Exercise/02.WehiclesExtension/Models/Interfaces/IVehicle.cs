﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models.Interfaces
{
    public interface IVehicle
    {
        double FuelQuantity { get;}

        double FueluelConsumption { get;}

        double TankCapacity { get;}

        string Drive(double distance, bool isIncreaseComsumption = true);

        void Refuel(double liters);
    }
}
