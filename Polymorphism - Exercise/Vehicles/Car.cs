namespace Vehicles
{
    public class Car :Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
            : base(fuelQuantity, fuelConsumptionPerKm, tankCapacity)
        {
            this.airConditionConsumption = 0.9;
        }
    }
}
