namespace _02._Basic_Queue_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BasicQueueOperations
    {
        public static void Main()
        {
            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numbersToEnqueue = commands[0];
            int numbersToDequeue = commands[1];
            int numberToPeek = commands[2];
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> numbers = new Queue<int>();
            for (int i = 0; i < numbersToEnqueue; i++)
            {
                numbers.Enqueue(input[i]);
            }

            for (int i = 0; i < numbersToDequeue; i++)
            {
                numbers.Dequeue();
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
