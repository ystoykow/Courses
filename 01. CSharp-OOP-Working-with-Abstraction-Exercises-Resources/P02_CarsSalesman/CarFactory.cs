namespace P02_CarsSalesman
{
    using System.Linq;

    public class CarFactory
    {
        public Car Create(EngineCatalog engines, string[] parameters)
        {
            string model = parameters[0];
            string engineModel = parameters[1];
            Engine engine = engines.Engines.FirstOrDefault(x => x.Model == engineModel);

            if (parameters.Length == 3 && int.TryParse(parameters[2], out var weight))
            {
                return new Car(model, engine, weight);
            }
            else if (parameters.Length == 3)
            {
                string color = parameters[2];
                return new Car(model, engine, color);
            }
            else if (parameters.Length == 4)
            {
                string color = parameters[3];
                return new Car(model, engine, int.Parse(parameters[2]), color);
            }

            return new Car(model, engine);
        }
    }
}
