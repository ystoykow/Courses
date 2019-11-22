﻿namespace Cars
{
    using System.Text;

    public class Tesla : ICar, IElectricCar
    {
        public Tesla(string model, string color, int batteryCount)
        {
            this.Model = model;
            this.Color = color;
            this.Battery = batteryCount;
        }

        public string Model { get; }

        public string Color { get; }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public int Battery { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Color} {this.GetType().Name} {this.Model} with {this.Battery} Batteries");
            sb.AppendLine(this.Start());
            sb.AppendLine(this.Stop());
            return sb.ToString().Trim();
        }
    }
}
