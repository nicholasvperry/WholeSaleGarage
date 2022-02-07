using System;

namespace wholesaleGarage
{
    public class Zero  : Vehicle, IElectricVehicle
{
    public double BatteryKWh { get; set; }
        public double CurrentChargePercentage { get; set; }

        public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Zero wizzes by you. Bzzzzzzzz!");
    }
        public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Zero stops with a quiet buzz.");
    }
    
    public override void Turn()
    {
        Console.WriteLine($"The {MainColor} Zero turns after seeing a friend.");
    }
    
}
}