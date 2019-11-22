namespace P01_RawData
{
    using System;

    public class RawData
    {
        public static void Main()
        {
            EngineFactory engineFactory = new EngineFactory();
            TireFactory tireFactory = new TireFactory();
            CargoFactory cargoFactory = new CargoFactory();
            CarCatalog carCatalog = new CarCatalog(engineFactory,tireFactory,cargoFactory);
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                carCatalog.Add(parameters);
            }

            string command = Console.ReadLine();

            Filter filter = new Filter();
            Console.WriteLine(filter.GetCars(command,carCatalog));
        }
    }
}
