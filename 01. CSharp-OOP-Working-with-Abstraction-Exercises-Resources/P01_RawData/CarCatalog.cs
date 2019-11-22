namespace P01_RawData
{
    using System.Collections.Generic;

    public class CarCatalog
    {
        private List<Car> cars;
        private EngineFactory engineFactory;
        private TireFactory tireFactory;
        private CargoFactory cargoFactory;

        public CarCatalog(EngineFactory engineFactory,TireFactory tireFactory,CargoFactory cargoFactory)
        {
            this.cars = new List<Car>();
            this.engineFactory = engineFactory;
            this.tireFactory = tireFactory;
            this.cargoFactory = cargoFactory;
        }

        public void Add(string[] parameters)
        {
            string model = parameters[0];
            int engineSpeed = int.Parse(parameters[1]);
            int enginePower = int.Parse(parameters[2]);
            int cargoWeight = int.Parse(parameters[3]);
            string cargoType = parameters[4];

            Cargo cargo = cargoFactory.Create(cargoWeight, cargoType);
            Engine engine = engineFactory.Create(engineSpeed, enginePower);
            Tire[] tires = GetTires(parameters);
            Car currentCar = new Car(model, engine, cargo, tires);
            this.cars.Add(currentCar);
        }

        private Tire[] GetTires(string[] parameters)
        {
            Tire[] tires = new Tire[4];
            int tireIndex = 0;
            for (int j = 5; j <= 12; j += 2)
            {
                double currentTirePressure = double.Parse(parameters[j]);
                int currentTireAge = int.Parse(parameters[j + 1]);
                Tire currentTire = tireFactory.Create(currentTirePressure, currentTireAge);
                tires[tireIndex] = currentTire;
                tireIndex++;
            }

            return tires;
        }

        public List<Car> GetCars()
        {
            return this.cars;
        }
    }
}
