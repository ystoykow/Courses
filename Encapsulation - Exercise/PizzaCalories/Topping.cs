namespace PizzaCalories
{
    using System;
    public class Topping
    {
        private string type;
        private double weight;
        private double baseCalories = 2;
        private double typeModifier;

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public string Type
        {
            get => this.type;
            set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.type = value;
            }
        }

        public double Weight
        {
            get => this.weight;
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range [1..50].");
                }

                this.weight = value;
            }
        }

        private void GetModifiers()
        {
            if (this.type.ToLower() == "meat")
            {
                this.typeModifier = 1.2;
            }
            else if (this.type.ToLower() == "veggies")
            {
                this.typeModifier = 0.8;
            }
            else if (this.type.ToLower() == "sauce")
            {
                this.typeModifier = 0.9;
            }
            else if (this.type.ToLower() == "cheese")
            {
                this.typeModifier = 1.1;
            }
        }

        public double CalculateCalories()
        {
            GetModifiers();
            return (this.baseCalories * this.weight) * this.typeModifier;
        }
    }
}
