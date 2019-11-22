namespace _04._Find_Evens_or_Odds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FindEvensOrOdds
    {
       public static void Main()
       {
           int[] numbersRange = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
               .ToArray();
           int start = numbersRange[0];
           int end = numbersRange[1];
           string evenOrOdd = Console.ReadLine();
           Predicate<int> isEvenOrOdd = x=> evenOrOdd == "odd" ?  x % 2 != 0 : x % 2 == 0;
           List<int> numbers = new List<int>();
           for (int i = start; i <= end; i++)
           {
               numbers.Add(i);
           }

           Console.WriteLine(string.Join(" ",numbers.Where(x=>isEvenOrOdd(x))));
       }
    }
}
