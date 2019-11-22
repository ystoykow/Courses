namespace WildFarm
{
    using System.Collections.Generic;

    public class Mouse:Mammal
    {
        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
            this.eatableFood = new List<string>
            {
                typeof(Vegetable).Name,
                typeof(Fruit).Name
            };

            this.weightGain = 0.1;
        }

        public override string ProduceSound()
        {
            return "Squeak";
        }
    }
}
