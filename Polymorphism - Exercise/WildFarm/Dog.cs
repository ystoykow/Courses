namespace WildFarm
{
    using System.Collections.Generic;

    public class Dog:Mammal
    {
        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
            this.eatableFood = new List<string>
            {
                typeof(Meat).Name
            };

            this.weightGain = 0.4;
        }

        public override string ProduceSound()
        {
            return "Woof!";
        }
    }
}
