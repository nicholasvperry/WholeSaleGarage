using System;

namespace wholesaleGarage
{
    public class Tesla  : Vehicle , IElectricVehicle
    {
        public double BatteryKWh { get ; set; }
        public double CurrentChargePercentage { get; set; }

        
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla speeds by. Hummmmmm!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla stops much slower that it goes.");
        }
    
        public override void Turn()
        {
            Console.WriteLine($"The {MainColor} Tesla turns behind Taco Bell.");
        }
   
    }
}