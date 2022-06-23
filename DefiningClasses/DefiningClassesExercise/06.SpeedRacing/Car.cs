using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public Car(string model, double fuel, double fuelPerKm)
        {
            this.Model = model;
            this.FuelAmount = fuel;
            this.FuelConsumptionPerKilometer = fuelPerKm;
        }
        public void Drive(double distance)
        {
            var fuelLeft = this.FuelAmount - (distance * FuelConsumptionPerKilometer);
            if (fuelLeft >= 0)
            {
                this.FuelAmount = fuelLeft;
                this.TravelledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
