using System;

namespace wholesaleGarage
{
    public class Ram : Vehicle, IGasVehicles
{
    public double FuelCapacity { get; set; }
        public double CurrentTankPercentage { get; set; }

        public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Ram drives by. Clank! Clank!");
    }
    
    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Ram slowly comes to a stop after breaking down.");
    }
    
    public override void Turn()
    {
        Console.WriteLine($"The {MainColor} Ram turns right trying to make it to the mechanic.");
    }
    

}
}