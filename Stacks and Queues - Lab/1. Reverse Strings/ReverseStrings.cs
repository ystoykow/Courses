namespace _1._Reverse_Strings
{
    using System;
    using System.Collections.Generic;

    public class ReverseStrings
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Stack<char> text = new Stack<char>();

            foreach (var symbol in input)
            {
                text.Push(symbol);
            }

            while (text.Count != 0)
            {
                Console.Write(text.Pop());
            }

            Console.WriteLine();
         }
    }
}
