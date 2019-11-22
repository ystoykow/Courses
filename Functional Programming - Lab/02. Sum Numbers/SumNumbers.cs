namespace _02._Sum_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumNumbers
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            Console.WriteLine(numbers.Count);
            Console.WriteLine(numbers.Sum());
        }
    }
}
