namespace _08._Custom_Comparator
{
    using System;
    using System.Linq;

    public class CustomComparator
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            Func<int, int, int> sortFunc = (x, y) => (x % 2 == 0 && y % 2 != 0) ? -1
                : (x % 2 != 0 && y % 2 == 0) ? 1
                : x.CompareTo(y);
            Array.Sort(numbers, new Comparison<int>(sortFunc));
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
