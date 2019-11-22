namespace Animals
{
   public class Kitten:Cat
   {
       private const string KittensGender = "Female";
        public Kitten(string name, int age) 
            : base(name, age, KittensGender)
        {
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
