namespace _06._Auto_Repair_and_Service
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AutoRepairAndService
    {
        public static void Main()
        {
            Queue<string> cars = new Queue<string>(Console.ReadLine().Split());
            Stack<string> served = new Stack<string>();
            string[] input = Console.ReadLine().Split();
            while (input[0] != "End")
            {
                    if (input[0] == "Service" && cars.Count > 0)
                    {
                        string currentCar = cars.Dequeue();
                        served.Push(currentCar);
                        Console.WriteLine($"Vehicle {currentCar} got served.");
                    }
                    else if (input[0] == "History")
                    {
                        Console.WriteLine(string.Join(", ", served));
                    }
                    else if (input[0].Contains("CarInfo"))
                    {
                        string[] tokens = input[0].Split('-');

                        if (served.Contains(tokens[1]))
                        {
                            Console.WriteLine($"Served.");
                        }
                        else
                        {
                            Console.WriteLine("Still waiting for service.");
                        }
                    }

                input = Console.ReadLine().Split();
            }

            if (cars.Count > 0)
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", cars)}");
            }

            Console.WriteLine($"Served vehicles: {string.Join(", ", served)}");
        }
    }
}
