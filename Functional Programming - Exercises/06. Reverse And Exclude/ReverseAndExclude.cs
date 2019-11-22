namespace _06._Reverse_And_Exclude
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ReverseAndExclude
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Reverse().ToList();
            int number = int.Parse(Console.ReadLine());
            Predicate<int> filter = x => x % number != 0;
            Console.WriteLine(string.Join(" ",numbers.Where(x=>filter(x))));
        }
    }
}
