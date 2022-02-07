using System;


namespace wholesaleGarage
{
    public interface IGasVehicles
    {
        double CurrentTankPercentage {get; set;}
        double FuelCapacity { get; set; }

        void RefuelTank() {
            CurrentTankPercentage = 100;
            
        }
    }

}