namespace BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<IBuyer> citizens = new List<IBuyer>();
            int buyersCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < buyersCount; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                if (tokens.Length == 3)
                {
                    string name = tokens[0];
                    int age = int.Parse(tokens[1]);
                    string group = tokens[2];
                    IBuyer rebel = new Rebel(name, age, group);
                    citizens.Add(rebel);
                }
                else if (tokens.Length == 4)
                {
                    string name = tokens[0];
                    int age = int.Parse(tokens[1]);
                    string id = tokens[2];
                    string birthday = tokens[3];
                    IBuyer citizen = new Citizen(name, age, id, birthday);
                    citizens.Add(citizen);
                }
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                if (citizens.Any(c => c.Name == command))
                {
                    citizens.First(c=>c.Name==command).BuyFood();
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(citizens.Sum(c=>c.Food));
        }
    }
}
