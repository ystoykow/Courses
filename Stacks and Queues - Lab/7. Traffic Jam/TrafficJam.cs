using System;
using System.Collections.Generic;

namespace _7._Traffic_Jam
{
    public class TrafficJam
    {
        public static void Main()
        {
            int carsCanPass = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            Queue<string> carsInJam = new Queue<string>();
            int passedCarsCounter = 0;

            while (input != "end")
            {
                if (input == "green")
                {
                    if (carsInJam.Count >= carsCanPass)
                    {

                        for (int i = 0; i < carsCanPass; i++)
                        {
                            Console.WriteLine($"{carsInJam.Dequeue()} passed!");
                            passedCarsCounter++;
                        }
                    }
                    else
                    {
                        while (carsInJam.Count != 0)
                        {
                            Console.WriteLine($"{carsInJam.Dequeue()} passed!");
                            passedCarsCounter++;
                        }
                    }
                }
                else
                {
                    carsInJam.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{passedCarsCounter} cars passed the crossroads.");
        }
    }
}
