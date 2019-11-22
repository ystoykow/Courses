namespace _03._Maximum_and_Minimum_Element
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MaximumAndMinimumElement
    {
        public static void Main()
        {
            int countQueries = int.Parse(Console.ReadLine());
            Stack<int> sequence = new Stack<int>();
            for (int i = 0; i < countQueries; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (input[0] == 1)
                {
                    sequence.Push(input[1]);
                }
                else if (input[0] == 2 && sequence.Count > 0)
                {
                    sequence.Pop();
                }
                else if (input[0] == 3 && sequence.Count > 0)
                {
                    Console.WriteLine(sequence.Max());
                }
                else if (input[0] == 4 && sequence.Count > 0)
                {
                    Console.WriteLine(sequence.Min());
                }
            }

            Console.WriteLine(string.Join(", ", sequence));
        }
    }
}
