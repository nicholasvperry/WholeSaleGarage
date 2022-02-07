using System;

namespace wholesaleGarage
{
    public class Cessna : Vehicle, IGasVehicles
{
    public double FuelCapacity { get; set; }
    
    public double CurrentTankPercentage { get; set; }

    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Cessna comes to a stop on the grass runway.");
    }
    
    public override void Turn()
    {
        Console.WriteLine($"The {MainColor} Cessna banks makes a right final turn.");
    }

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Cessna flies by. Zoooooom!");
    }
}
}