using System.Collections.Generic;

namespace WildFarm
{
    public class Hen:Bird
    {
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
            this.eatableFood = new List<string> {
                typeof(Meat).Name,
                typeof(Vegetable).Name,
                typeof(Fruit).Name,
                typeof(Seeds).Name };

            this.weightGain = 0.35;
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }
}
