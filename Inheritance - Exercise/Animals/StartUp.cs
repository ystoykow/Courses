namespace Animals
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            List<Animal> animalCollection = new List<Animal>();
            string input = Console.ReadLine();
            while (input!= "Beast!")
            {
                string[] tokens = Console.ReadLine().Split();
                try
                {
                    if (input == "Cat")
                    {
                        string name = tokens[0];
                        int age = int.Parse(tokens[1]);
                        string gender = tokens[2];
                        Cat cat = new Cat(name,age,gender);
                        animalCollection.Add(cat);
                    }
                    else if (input == "Dog")
                    {
                        string name = tokens[0];
                        int age = int.Parse(tokens[1]);
                        string gender = tokens[2];
                        Dog dog = new Dog(name, age, gender);
                        animalCollection.Add(dog);
                    }
                    else if (input == "Frog")
                    {
                        string name = tokens[0];
                        int age = int.Parse(tokens[1]);
                        string gender = tokens[2];
                        Frog frog = new Frog(name, age, gender);
                        animalCollection.Add(frog);
                    }
                    else if (input == "Kitten")
                    {
                        string name = tokens[0];
                        int age = int.Parse(tokens[1]);
                        Kitten kittens = new Kitten(name, age);
                        animalCollection.Add(kittens);
                    }
                    else if (input == "Tomcat")
                    {
                        string name = tokens[0];
                        int age = int.Parse(tokens[1]);
                        Tomcat tomcat = new Tomcat(name, age);
                        animalCollection.Add(tomcat);
                    }

                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }

                input = Console.ReadLine();
            }

            foreach (var animal in animalCollection)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
