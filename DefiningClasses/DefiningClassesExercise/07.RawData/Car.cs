using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine = new Engine();
        public Cargo Cargo = new Cargo();
        public List<Tire>Tires = new List<Tire>();
        Tire tire1 = new Tire();
        Tire tire2 = new Tire();
        Tire tire3 = new Tire();
        Tire tire4 = new Tire();

        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType, double tire1Pressure, int tire1Age, double tire2Pressure, int tire2Age, double tire3Pressure, int tire3Age, double tire4Pressure, int tire4Age)
        {
            this.Model = model;
            this.Engine.Speed = engineSpeed;
            this.Engine.Power = enginePower;
            this.Cargo.Weight = cargoWeight;
            this.Cargo.Type = cargoType;
            tire1.Pressure = tire1Pressure;
            tire1.Age = tire1Age;
            tire2.Pressure = tire2Pressure;
            tire2.Age = tire2Age;
            tire3.Pressure = tire3Pressure;
            tire3.Age = tire3Age;
            tire4.Pressure = tire3Pressure;
            tire4.Age = tire4Age;
            Tires.Add(tire1);
            Tires.Add(tire2);
            Tires.Add(tire3);
            Tires.Add(tire4);           
        }

        public void Print(string cargoType, List<Car> cars)
        {

        }
    }
}
