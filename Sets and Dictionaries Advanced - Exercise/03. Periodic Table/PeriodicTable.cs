namespace _03._Periodic_Table
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PeriodicTable
    {
        public static void Main()
        {
            int recordsCount = int.Parse(Console.ReadLine());
            HashSet<string> periodicTable = new HashSet<string>();
            for (int i = 0; i < recordsCount; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < input.Length; j++)
                {
                    periodicTable.Add(input[j]);
                }
            }

            Console.WriteLine(string.Join(" ",periodicTable.OrderBy(x=>x)));
        }
    }
}
