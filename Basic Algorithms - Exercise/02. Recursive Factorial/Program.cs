namespace _02._Recursive_Factorial
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int result = Factorial(number);
            Console.WriteLine(result);
        }

        private static int Factorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }

            return number * Factorial(--number);
        }
    }
}
