namespace _01._Sort_Even_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortEvenNumbers
    {
       public static void Main()
       {
           List<int> numbers =Console.ReadLine()
               .Split(", ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .Where(x => x % 2 == 0)
               .OrderBy(x => x)
               .ToList();
           Console.WriteLine(string.Join(", ",numbers));
       }
    }
}
