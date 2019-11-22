using System.Collections.Generic;

namespace Froggy
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Lake currentLake = new Lake(input);
            List<int> result = new List<int>();
            foreach (var stone in currentLake)
            {
                result.Add(stone);
            }

            Console.WriteLine(string.Join(", ",result));
        }
    }
}
