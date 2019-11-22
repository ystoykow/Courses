namespace _2._Stack_Sum
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StackSum
    {
        public static void Main()
        {
            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] input = Console.ReadLine().Split();

            Stack<int> numbers = new Stack<int>(inputNumbers);
            
            while (input[0].ToLower() != "end")
            {
                string command = input[0].ToLower();

                if (command == "add")
                {
                    numbers.Push(int.Parse(input[1]));
                    numbers.Push(int.Parse(input[2]));
                }
                else
                {
                    int count = int.Parse(input[1]);

                    if (count <= numbers.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }

                input = Console.ReadLine().Split();
            }

            int sum = 0;
            while (numbers.Count!=0)
            {
                sum += numbers.Pop();
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
