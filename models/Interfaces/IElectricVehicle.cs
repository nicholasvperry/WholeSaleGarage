using System;


namespace wholesaleGarage
{
    public interface IElectricVehicle
    {
        double BatteryKWh { get; set; }
        double CurrentChargePercentage {get; set;}

        void ChargeBattery() {
            CurrentChargePercentage = 100;
        }
    }

}