namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            try
            {
                List<Person> people = new List<Person>();
                List<Product> products = new List<Product>();
                string[] peopleData = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < peopleData.Length; i++)
                {
                    string[] args = peopleData[i].Split("=");
                    string name = args[0];
                    decimal money = decimal.Parse(args[1]);
                    Person current = new Person(name, money);
                    people.Add(current);
                }

                string[] productsData = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < productsData.Length; i++)
                {
                    string[] args = productsData[i].Split("=");
                    string name = args[0];
                    decimal cost = decimal.Parse(args[1]);
                    Product current = new Product(name, cost);
                    products.Add(current);
                }
                string command = Console.ReadLine();
                while (command != "END")
                {
                    string[] args = command.Split(" ");
                    string personName = args[0];
                    string productName = args[1];

                    Person currentPerson = people.FirstOrDefault(p => p.Name == personName);
                    Product currentProduct = products.FirstOrDefault(p => p.Name == productName);

                    if (currentProduct != null && currentPerson != null)
                    {
                        Console.WriteLine(currentPerson.Buy(currentProduct));
                    }

                    command = Console.ReadLine();
                }

                foreach (var person in people)
                {
                    Console.WriteLine(person);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }
    }
}
