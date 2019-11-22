namespace _12._Cups_and_Bottles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CupsAndBottles
    {
        public static void Main()
        {
            Queue<int> cups = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));

            int wastedWater = 0;

            while (cups.Count != 0 && bottles.Count != 0)
            {
                int currentCup = cups.Dequeue();

                while (currentCup > 0)
                {
                    int currentBottle = bottles.Pop();

                    if (currentBottle > currentCup)
                    {
                        wastedWater += currentBottle - currentCup;
                    }

                    currentCup -= currentBottle;
                }
            }

            if (cups.Count == 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }
            else if (bottles.Count == 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
