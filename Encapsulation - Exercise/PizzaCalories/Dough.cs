namespace PizzaCalories
{
    using System;

    public class Dough
    {
        private double baseCalories = 2;
        private string flour;
        private string technique;
        private double weight;
        private double flourModifier;
        private double techniqueModifier;

        public Dough(string flour, string technique,double weight)
        {
            this.Flour = flour;
            this.Technique = technique;
            this.Weight = weight;
        }

        public string Flour
        {
            get => this.flour;
            set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.flour = value;
            }
        }


        public string Technique
        {
            get => this.technique;
            set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.technique = value;
            }
        }

        public double Weight
        {
            get => this.weight;
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                this.weight = value;
            }
        }

        private void GetModifiers()
        {
            if (this.flour.ToLower() == "white")
            {
                this.flourModifier = 1.5;
            }
            else if (this.flour.ToLower() == "wholegrain")
            {
                this.flourModifier = 1;
            }

            if (this.technique.ToLower() == "crispy")
            {
                this.techniqueModifier = 0.9;
            }
            else if (this.technique.ToLower() == "chewy")
            {
                this.techniqueModifier = 1.1;
            }
            else if (this.technique.ToLower() == "homemade")
            {
                this.techniqueModifier = 1;
            }
        }

        public double CalculateCalories()
        {
            GetModifiers();
            return (this.baseCalories * this.weight) * this.flourModifier * this.techniqueModifier;
        }
    }
}