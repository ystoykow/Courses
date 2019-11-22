namespace _01._Basic_Stack_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BasicStackOperations
    {
        public static void Main()
        {
            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numbersToPush = commands[0];
            int numbersToPop = commands[1];
            int numberToPeek = commands[2];
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < numbersToPush; i++)
            {
                numbers.Push(input[i]);
            }

            for (int i = 0; i < numbersToPop; i++)
            {
                numbers.Pop();
            }

            if (numbers.Contains(numberToPeek))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (numbers.Count > 0)
                {
                    Console.WriteLine(numbers.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
