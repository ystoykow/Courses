namespace PizzaCalories
{
    using System;
    public class Program
    {
        public static void Main()
        {
            try
            {
                string[] input = Console.ReadLine().Split();
                string pizzaName = input[1];
                Pizza pizza = new Pizza(pizzaName);
                input = Console.ReadLine().Split();
                string flour = input[1];
                string technique = input[2];
                double weight = double.Parse(input[3]);
                Dough dough = new Dough(flour, technique, weight);
                input = Console.ReadLine().Split();
                pizza.AddDough(dough);
                while (input[0] != "END")
                {
                    string topping = input[1];
                    double weightt = double.Parse(input[2]);
                    Topping top = new Topping(topping, weightt);
                    pizza.AddTopping(top);
                    input = Console.ReadLine().Split();
                }

                Console.WriteLine(pizza);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
