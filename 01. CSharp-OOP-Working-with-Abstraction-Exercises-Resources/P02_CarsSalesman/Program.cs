namespace P02_CarsSalesman
{
    using System;

    public class CarSalesman
    {
        public static void Main()
        {
            CarFactory carFactory= new CarFactory();
            CarCatalog cars = new CarCatalog();
            EngineFactory engineFactory = new EngineFactory();
            EngineCatalog engines = new EngineCatalog();
            int engineCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < engineCount; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                engines.Add(engineFactory.Create(parameters));
            }

            int carCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < carCount; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                cars.Add(carFactory.Create(engines,parameters));
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
