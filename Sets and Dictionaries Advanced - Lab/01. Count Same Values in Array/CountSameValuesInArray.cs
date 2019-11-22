namespace _01._Count_Same_Values_in_Array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountSameValuesInArray
    {
        public static void Main()
        {
            double[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse)
                .ToArray();
            Dictionary<double,int> countNumbers = new Dictionary<double, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!countNumbers.ContainsKey(input[i]))
                {
                    countNumbers.Add(input[i],0);
                }

                countNumbers[input[i]]++;
            }

            foreach (var num in countNumbers)
            {
                Console.WriteLine($"{num.Key} - {num.Value} times");
            }
        }
    }
}
