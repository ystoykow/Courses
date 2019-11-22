namespace WildFarm
{
    using System.Collections.Generic;

    public class Cat:Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
            this.eatableFood = new List<string>
            {
                typeof(Meat).Name, 
                typeof(Vegetable).Name
            };

            this.weightGain = 0.3;
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
