namespace Vehicles
{
    using System;

    public abstract class Vehicle
    {
        protected double fuelConsumptionPerKm;
        protected double airConditionConsumption;
        private double fuelQuantity;

        protected Vehicle(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
        {
            this.fuelConsumptionPerKm = fuelConsumptionPerKm;
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
        }

        public double FuelQuantity
        {
            get => this.fuelQuantity;
            protected set
            {
                if (value > this.TankCapacity)
                {
                    this.fuelQuantity = 0;
                }
                else
                {
                    this.fuelQuantity = value;
                }
            }
        }

        public double TankCapacity { get; protected set; }

        public virtual string Drive(double km, bool isAirConditionTurnOn)
        {
            double consumption = this.fuelConsumptionPerKm;
            if (isAirConditionTurnOn)
            {
                consumption += this.airConditionConsumption;
            }

            if (km * consumption > this.FuelQuantity)
            {
                return $"{this.GetType().Name} needs refueling";
            }

            this.FuelQuantity -= km * consumption;
            return $"{this.GetType().Name} travelled {km} km";
        }

        public virtual void Refuel(double liters)
        {
            if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            else if (this.fuelQuantity + liters > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
            }

            this.FuelQuantity += liters;
        }
    }
}
