namespace WildFarm
{
    using System.Collections.Generic;

    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
            this.eatableFood= new List<string>
            {
                typeof(Meat).Name
            };

            this.weightGain = 1;
        }

        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
    }
}
