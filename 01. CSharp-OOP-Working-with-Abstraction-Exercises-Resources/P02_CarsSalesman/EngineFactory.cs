﻿namespace P02_CarsSalesman
{
    public class EngineFactory
    {
        public Engine Create(string[] parameters)
        {
            string model = parameters[0];
            int power = int.Parse(parameters[1]);

            if (parameters.Length == 3 && int.TryParse(parameters[2], out var displacement))
            {
                return new Engine(model, power, displacement);
            }
            else if (parameters.Length == 3)
            {
                string efficiency = parameters[2];
                return new Engine(model, power, efficiency);
            }
            else if (parameters.Length == 4)
            {
                string efficiency = parameters[3];
                return new Engine(model, power, int.Parse(parameters[2]), efficiency);
            }

            return new Engine(model, power);
        }
    }
}
