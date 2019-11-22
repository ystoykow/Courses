namespace WildFarm
{
    using System;
    using System.Collections.Generic;

    public abstract class Animal
    {
        protected double weightGain;
        protected List<string> eatableFood;

        protected Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
            this.FoodEaten = 0;
        }

        public string Name { get; private set; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }

        public void Eat(Food food)
        {
            if (!this.eatableFood.Contains(food.GetType().Name))
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }

            this.Weight += food.Quantity * weightGain;
            this.FoodEaten += food.Quantity;
        }

        public abstract string ProduceSound();

        public override string ToString()
        {
            return $"{ this.GetType().Name} [{this.Name},";
        }
    }
}
