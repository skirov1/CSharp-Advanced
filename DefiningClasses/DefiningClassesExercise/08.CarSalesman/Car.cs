using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine = new Engine();
        public int Weight { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return $"{this.Model}:\n" +
                $"  {this.Engine.Model}:\n" +
                $"    Power: {this.Engine.Power}" +
                $"";
        }
    }
}
