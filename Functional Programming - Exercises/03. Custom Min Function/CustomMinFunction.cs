namespace _03._Custom_Min_Function
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CustomMinFunction
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToList();

            Func<List<int>, int> minNumber = GetMin;
            Console.WriteLine(minNumber(numbers));
        }

        public static int GetMin(List<int> numbers)
        {
            int min = int.MaxValue;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            return min;
        }
    }
}