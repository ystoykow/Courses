namespace WildFarm
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            List<Animal> animals = new List<Animal>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] animalArgs = input.Split();
                Animal animal = AnimalFactory.Create(animalArgs);
                Console.WriteLine(animal.ProduceSound());
                string[] foodArgs = Console.ReadLine().Split();
                Food food = FoodFactory.Create(foodArgs);
                try
                {
                    animal.Eat(food);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                animals.Add(animal);

                input = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }

}
