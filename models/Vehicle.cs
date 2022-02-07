using System;

namespace wholesaleGarage
{
   public class Vehicle
{
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }
    public string Name {get; set;}

    public virtual void Drive()
    {
        Console.WriteLine("Vrooom!");
    }
    public virtual void Stop()
    {
        Console.WriteLine("RRRRR!");
    }
    public virtual void Turn()
    {
        Console.WriteLine("Screetch");
    }
}
}