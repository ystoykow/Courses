namespace _5._Special_Cars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class SpecialCars
    {
        public class Tire
        {
            public int Year { get; set; }

            public double Pressure { get; set; }
        }

        public class Engine
        {
            public int HorsePower { get; set; }

            public double CubicCapacity { get; set; }
        }

        public class Car
        {
            public string Make { get; set; }

            public string Model { get; set; }

            public int Year { get; set; }

            public double FuelQuantity { get; set; }

            public double FuelConsumption { get; set; }

            public Engine Engine { get; set; }

            public Tire[] Tires { get; set; }

            public void Drive(double distance)
            {
                bool canContinue = this.FuelQuantity - (distance * (this.FuelConsumption / 100)) >= 0;
                if (canContinue)
                {
                    this.FuelQuantity -= (distance * (this.FuelConsumption / 100));
                }
            }

            public string GetInformation()
            {
                StringBuilder result = new StringBuilder();

                result.AppendLine($"Make: {this.Make}");
                result.AppendLine($"Model: {this.Model}");
                result.AppendLine($"Year: {this.Year}");
                result.AppendLine($"HorsePowers: {this.Engine.HorsePower}");
                result.Append($"FuelQuantity: {this.FuelQuantity}");

                return result.ToString();
            }
        }

        public static void Main()
        {
            string input = Console.ReadLine();
            List<Tire[]> tireCollection = new List<Tire[]>();
            while (input != "No more tires")
            {
                Tire[] currentTireCollection = new Tire[4];
                string[] tiresAsString = input.Split();
                for (int i = 0; i < currentTireCollection.Length; i++)
                {
                    int year = int.Parse(tiresAsString[i * 2]);
                    double pressure = double.Parse(tiresAsString[i * 2 + 1]);
                    Tire currentTire = new Tire()
                    {
                        Pressure = pressure,
                        Year = year
                    };

                    currentTireCollection[i] = currentTire;
                }

                tireCollection.Add(currentTireCollection);
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            List<Engine> engineCollection = new List<Engine>();
            while (input != "Engines done")
            {
                string[] enginesParams = input.Split();
                int horsePower = int.Parse(enginesParams[0]);
                double cubicCapacity = double.Parse(enginesParams[1]);
                Engine currentEngine = new Engine()
                {
                    CubicCapacity = cubicCapacity,
                    HorsePower = horsePower
                };

                engineCollection.Add(currentEngine);
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            List<Car> carCollection = new List<Car>();
            while (input != "Show special")
            {
                string[] carParams = input.Split();
                string make = carParams[0];
                string model = carParams[1];
                int year = int.Parse(carParams[2]);
                double fuelQuantity = double.Parse(carParams[3]);
                double fuelConsumption = double.Parse(carParams[4]);
                int engineIndex = int.Parse(carParams[5]);
                int tireCollectionIndex = int.Parse(carParams[6]);
                Car currentCar = new Car()
                {
                    Make = make,
                    Model = model,
                    Year = year,
                    FuelQuantity = fuelQuantity,
                    FuelConsumption = fuelConsumption,
                    Engine = engineCollection[engineIndex],
                    Tires = tireCollection[tireCollectionIndex]
                };
                
                carCollection.Add(currentCar);
                input = Console.ReadLine();
            }

            foreach (var car in carCollection
                .Where(c=>c.Year>=2017)
                .Where(c=>c.Engine.HorsePower>330)
                .Where(c=>c.Tires
                              .Select(p=>p.Pressure)
                              .Sum()>=9 && 
                          c.Tires
                              .Select(p=>p.Pressure)
                              .Sum()<=10))
            {
                car.Drive(20);
                Console.WriteLine(car.GetInformation());
            }
        }
    }
}
