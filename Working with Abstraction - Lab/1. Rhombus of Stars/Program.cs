namespace _1._Rhombus_of_Stars
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            PrintRhombus(size);
        }

        public static void PrintRhombus(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                Console.Write(new string(' ', size - i));
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            for (int i = size-1; i >= 0; i--)
            {
                Console.Write(new string(' ', size - i));
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }
    }
}
