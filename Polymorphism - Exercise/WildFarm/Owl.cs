using System.Collections.Generic;

namespace WildFarm
{
    public class Owl:Bird
    {
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
            this.eatableFood = new List<string>
            {
                typeof(Meat).Name
            };

            this.weightGain = 0.25;
        }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
    }
}
