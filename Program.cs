using System;
using System.Collections.Generic;

namespace wholesaleGarage
{
    class Program
    {
        static void Main (string[] args)
        {
            Zero fxs = new Zero()
            {Name = "FXS Zero",
            CurrentChargePercentage = new Random().Next(0, 100)};
            Zero fx = new Zero()
            {Name = "FX Zero",
            CurrentChargePercentage = new Random().Next(0, 100)};;
            Tesla modelS = new Tesla()
            {Name = "Tesla ModelS",
            CurrentChargePercentage = new Random().Next(0, 100)};

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/

            Ram ram = new Ram ()
            {Name = "Ram 2500",
            CurrentTankPercentage = new Random().Next(0, 100)};
            Cessna cessna150 = new Cessna ()
            {Name = "Cessna",
            CurrentTankPercentage = new Random().Next(0, 100)};

            List<IGasVehicles> gasVehicles = new List<IGasVehicles>() {
                ram, cessna150
            };

            Console.WriteLine("Gas Vehicles");
            foreach(IGasVehicles gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach(IGasVehicles gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach(IGasVehicles gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
        }
    }
}
