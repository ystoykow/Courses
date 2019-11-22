namespace PizzaCalories
{
    using System.Linq;
    using System.Collections.Generic;
    using System;

    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name)
        {
            this.Name = name;
            this.toppings=new List<Topping>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value) ||
                    string.IsNullOrEmpty(value) ||
                    value.Length > 15 ||
                    value.Length < 1)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }
        }

        public int ToppingsCount => this.toppings.Count;

        public Dough Dough
        {
            private get => this.dough;
            set => this.dough = value;
        }

        public double TotalCalories
        {
            get
            {
                return this.dough.CalculateCalories() + toppings.Sum(x => x.CalculateCalories());
            }
        }

        public void AddTopping(Topping topping)
        {
            if (this.toppings.Count >9)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }

            this.toppings.Add(topping);
        }

        public void AddDough(Dough dough)
        {
            this.Dough = dough;
        }

        public override string ToString()
        {
            return $"{this.name} - {this.dough.CalculateCalories()+toppings.Sum(x=>x.CalculateCalories()):f2} Calories.";
        }
    }
}