namespace _02._Sets_of_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SetsOfElements
    {
        public static void Main()
        {
            int[] sets = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();
            for (int i = 0; i < sets[0]+sets[1]; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (i < sets[0])
                {
                    first.Add(input);
                }
                else
                {
                    second.Add(input);
                }
            }

            foreach (var number in first)
            {
                if (second.Contains(number))
                {
                    Console.Write($"{number} ");
                }
            }
        }
    }
}
