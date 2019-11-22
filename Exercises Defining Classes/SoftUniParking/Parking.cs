namespace SoftUniParking
{
    using System.Collections.Generic;
    using System.Linq;

    public class Parking
    {
        private List<Car> cars;
        private int capacity;

        public Parking(int capacity)
        {
            this.capacity = capacity;
            this.cars = new List<Car>();
        }

        public string AddCar(Car car)
        {
            string result = string.Empty;
            if (this.cars.Any(c => c.RegistrationNumber == car.RegistrationNumber))
            {
                result = "Car with that registration number, already exists!";
            }
            else if (this.cars.Count >= this.capacity)
            {
                result = "Parking is full!";
            }
            else
            {
                this.cars.Add(car);
                result = $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }

            return result;
        }

        public string RemoveCar(string registrationNumber)
        {
            string result = string.Empty;
            if (this.cars.Any(c => c.RegistrationNumber == registrationNumber))
            {
                result = "Car with that registration number, doesn't exist!";
            }
            else
            {
                this.cars.Remove(this.cars.FirstOrDefault(c => c.RegistrationNumber == registrationNumber));
                result = $"Successfully removed {registrationNumber}";
            }

            return result;
        }

        public Car GetCar(string registrationNumber)
        {
            Car currentCar = this.cars.FirstOrDefault(c => c.RegistrationNumber == registrationNumber);
            return currentCar;
        }

        public int Count()
        {
            return this.cars.Count;
        }
        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var number in registrationNumbers)
            {
                this.cars.RemoveAll(c => c.RegistrationNumber == number);
            }
        }
    }
}
