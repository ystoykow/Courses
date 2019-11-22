namespace _09._List_Of_Predicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ListOfPredicates
    {
        public static void Main()
        {
            int end = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            List<int> result = Enumerable.Range(1, end).ToList();

            for (int i = 0; i < numbers.Length; i++)
            {
                Predicate<int> divisible = x => { return x % numbers[i] == 0; };
                result = result.FindAll(divisible);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}