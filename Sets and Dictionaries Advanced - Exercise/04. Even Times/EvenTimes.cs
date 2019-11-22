namespace _04._Even_Times
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EvenTimes
    {
        public static void Main()
        {
            int recordsCount = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            for (int i = 0; i < recordsCount; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(currentNumber))
                {
                    numbers.Add(currentNumber, 0);
                }

                numbers[currentNumber]++;
            }

            foreach (var number in numbers.Where(x=>x.Value%2==0))
            {
                Console.WriteLine(number.Key);   
            }
        }
    }
}
