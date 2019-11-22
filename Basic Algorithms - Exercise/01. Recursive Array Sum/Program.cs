namespace _01._Recursive_Array_Sum
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int result = Sum(numbers,0);
            Console.WriteLine(result);
        }

        private static int Sum(int[] numbers, int index)
        {
            if (index == numbers.Length)
            {
                return 0;
            }

            return numbers[index] + Sum(numbers, ++index);
        }
    }
}
