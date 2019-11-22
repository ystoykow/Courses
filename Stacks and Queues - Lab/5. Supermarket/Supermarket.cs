namespace _5._Supermarket
{
    using System;
    using System.Collections.Generic;

    public class Supermarket
    {
       public static void Main()
        {
            Queue<string> customers = new Queue<string>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                if (input == "Paid")
                {
                    while (customers.Count != 0)
                    {
                        Console.WriteLine(customers.Dequeue());
                    }

                    input = Console.ReadLine();
                    continue;
                }

                customers.Enqueue(input);
                input = Console.ReadLine();
            }

            Console.WriteLine($"{customers.Count} people remaining.");
        }
    }
}
